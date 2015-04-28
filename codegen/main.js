var http = require("http"),
	fs = require("fs"),
	ejs = require("ejs"),
	colors = require("cli-color");

var error = colors.red, success = colors.green, info = colors.blue;

// VALID APPLICATIONS
var apps = {
	"AccuClass": {Name: "AccuClass", Url: "www.accuclass.net" },
	"CT": {Name: "ConferenceTracker", Url: "www.conftrac.com" },
	"AccuWB": {Name: "AccuWB", Url: "www.accuwb.com" },
	"AccuCampus": {Name: "AccuCampus", Url: "www.accucampus.net" },
	"AccuTraining": {Name: "AccuTraining", Url: "www.accutraining.net" },
	"AccuClub": {Name: "AccuClub", Url: "www.accuclub.net" }
};

var langDefs = {
	"NET": { types: {"numeric": "int", 
						"guid": "Guid", 
						"string": "string", 
						"boolean": "bool",
						"date-time": "DateTime"},
				GetType: function(t) {
					if (this.types[t]) return this.types[t];
					else return t;
				}
			}
};

// LOAD CONFIGURATIONS
if (process.argv.length != 4) {
	console.log(error("Please specify the language of the output and the application to get the documentation from:"));
	console.log("");
	console.log(info("Format: node main.js <language> <application>"));
	console.log(info("where: "));
	console.log(info("- language:	either NET, PHP, ASP or anyone available as a template."));
	console.log(info("- application:	either AccuClass, CT, AccuWB, AccuTraining, AccuClub or AccuCampus."));
	console.log("");
	console.log(info("For example: node main.js NET AccuClass"));
	console.log("");
	return;
}
var language = process.argv[2];
var app = apps[process.argv[3]];
if (!fs.existsSync("templates/" + language + "/")) {
	console.log(error("Template for language " + language + " does not exist."));
	return;
}
if (!app) {
	console.log(error("The specified application do not exist."));
	return;
}

/*deleteFolderRecursive("output/" + app.Name + "/");*/
fs.mkdir("output/" + app.Name + "/", function() {/*ignore error if folder exists*/});


// GET THE DOCUMENTATION
var options = {
	host: app.Url,
	port: 80,
	path: "/Service/?action=doc",
	method: "GET"
};

console.log(info("Reading document information..."));
http.get(options, function(res) {
	var body = "";
	res.on("data", function(chunk) {
		body += chunk;
	});
	res.on("end", function() {
		OnDocAvailable(JSON.parse(body));
	});
});

function OnDocAvailable(doc) {
	console.log(success("Actions Found: " + doc.results.length));
	
	fs.readFile("templates/" + language + "/action-interface.ejs", "utf-8", function(error, template) {
		RenderActionInterfaceTemplates(error, template, doc);
	});
}

// GENERATE THE TEMPLATES
function RenderActionInterfaceTemplates(error, template, doc) {

	if (error) { 
		console.log(error("Unable to read action-interface.ejs template!"));
		return;
	}

	for (var i=0;i<doc.results.length;i++) {
		var action = ExtendActionFromDoc(doc.results[i]);

		// Add the special param "filename" to enable includes in the correct directory.
		action.filename = __dirname + "/templates/" + language + '/action-interface.ejs';
		var rendered = ejs.render(template, action);

		fs.writeFile("output/" + app.Name + "/" + action.CommandName + ".cs", rendered, function(err) {
			if (err) console.log(err);
		});
	}
}

function ExtendActionFromDoc(action) {

	// Create a pascal case version of the command name, example:  
	// user.save -> ClassName = 'User' 
	// and Function = 'Save'
	action.ClassName = FirstLetterCapital(action.CommandName);
	if (action.ClassName.indexOf(".") >= 0) {
		action.FunctionName = FirstLetterCapital(action.ClassName.substr(action.ClassName.indexOf(".") + 1));
		action.ClassName = action.ClassName.substr(0, action.ClassName.indexOf("."));
	} else {
		action.FunctionName = "Execute"; 
	}

	action.AllParams = action.RequiredParameters.concat(action.OptionalParameters);

	action.requiresAuth = false;
	for (var p=0 ; p<action.AllParams.length; p++) {
		if (action.AllParams[p].Name != "token") continue;

		action.requiresAuth = true;
		action.AllParams.splice(p,1);
		if (action.RequiredParameters.length >= (p+1)) {
			action.RequiredParameters.splice(p,1);
		} else {
			action.OptionalParameters.splice(p-action.RequiredParameters.length, 1);
		}
	}

	action.app = app;
	action.language = langDefs[language];

	return action;
}

function FirstLetterCapital(text) {
	return text.substr(0,1).toUpperCase() + text.substr(1);
}



function deleteFolderRecursive(path) {
    var files = [];
    if( fs.existsSync(path) ) {
        files = fs.readdirSync(path);
        files.forEach(function(file,index){
            var curPath = path + "/" + file;
            if(fs.statSync(curPath).isDirectory()) { // recurse
                deleteFolderRecursive(curPath);
            } else { // delete file
                fs.unlinkSync(curPath);
            }
        });
        fs.rmdirSync(path);
    }
};







