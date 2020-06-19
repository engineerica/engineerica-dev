export * from './actionlogApi';
import { ActionlogApi } from './actionlogApi';
export * from './advroleApi';
import { AdvroleApi } from './advroleApi';
export * from './advrolesApi';
import { AdvrolesApi } from './advrolesApi';
export * from './appshareApi';
import { AppshareApi } from './appshareApi';
export * from './attendancelogApi';
import { AttendancelogApi } from './attendancelogApi';
export * from './attendancelogcommentApi';
import { AttendancelogcommentApi } from './attendancelogcommentApi';
export * from './bgjobApi';
import { BgjobApi } from './bgjobApi';
export * from './captchaApi';
import { CaptchaApi } from './captchaApi';
export * from './clientApi';
import { ClientApi } from './clientApi';
export * from './creditApi';
import { CreditApi } from './creditApi';
export * from './creditplanApi';
import { CreditplanApi } from './creditplanApi';
export * from './easyloginApi';
import { EasyloginApi } from './easyloginApi';
export * from './eventApi';
import { EventApi } from './eventApi';
export * from './exportApi';
import { ExportApi } from './exportApi';
export * from './featureApi';
import { FeatureApi } from './featureApi';
export * from './generalApi';
import { GeneralApi } from './generalApi';
export * from './holidayApi';
import { HolidayApi } from './holidayApi';
export * from './importApi';
import { ImportApi } from './importApi';
export * from './licenseApi';
import { LicenseApi } from './licenseApi';
export * from './locationApi';
import { LocationApi } from './locationApi';
export * from './memorizedreportApi';
import { MemorizedreportApi } from './memorizedreportApi';
export * from './menuApi';
import { MenuApi } from './menuApi';
export * from './myApi';
import { MyApi } from './myApi';
export * from './notificationApi';
import { NotificationApi } from './notificationApi';
export * from './notificationtopicApi';
import { NotificationtopicApi } from './notificationtopicApi';
export * from './pushApi';
import { PushApi } from './pushApi';
export * from './qrlabelsApi';
import { QrlabelsApi } from './qrlabelsApi';
export * from './qrloginApi';
import { QrloginApi } from './qrloginApi';
export * from './quickpanelApi';
import { QuickpanelApi } from './quickpanelApi';
export * from './reportApi';
import { ReportApi } from './reportApi';
export * from './roleApi';
import { RoleApi } from './roleApi';
export * from './ruleApi';
import { RuleApi } from './ruleApi';
export * from './searchApi';
import { SearchApi } from './searchApi';
export * from './securityApi';
import { SecurityApi } from './securityApi';
export * from './sessionregApi';
import { SessionregApi } from './sessionregApi';
export * from './settingApi';
import { SettingApi } from './settingApi';
export * from './ssoApi';
import { SsoApi } from './ssoApi';
export * from './stationApi';
import { StationApi } from './stationApi';
export * from './swipeApi';
import { SwipeApi } from './swipeApi';
export * from './tagApi';
import { TagApi } from './tagApi';
export * from './templateApi';
import { TemplateApi } from './templateApi';
export * from './termApi';
import { TermApi } from './termApi';
export * from './textcreditApi';
import { TextcreditApi } from './textcreditApi';
export * from './translationApi';
import { TranslationApi } from './translationApi';
export * from './userApi';
import { UserApi } from './userApi';
export * from './usergroupApi';
import { UsergroupApi } from './usergroupApi';
export * from './usersettingsApi';
import { UsersettingsApi } from './usersettingsApi';
import * as fs from 'fs';
import * as http from 'http';

export class HttpError extends Error {
    constructor (public response: http.ClientResponse, public body: any, public statusCode?: number) {
        super('HTTP request failed');
        this.name = 'HttpError';
    }
}

export interface RequestDetailedFile {
    value: Buffer;
    options?: {
        filename?: string;
        contentType?: string;
    }
}

export type RequestFile = string | Buffer | fs.ReadStream | RequestDetailedFile;

export const APIS = [ActionlogApi, AdvroleApi, AdvrolesApi, AppshareApi, AttendancelogApi, AttendancelogcommentApi, BgjobApi, CaptchaApi, ClientApi, CreditApi, CreditplanApi, EasyloginApi, EventApi, ExportApi, FeatureApi, GeneralApi, HolidayApi, ImportApi, LicenseApi, LocationApi, MemorizedreportApi, MenuApi, MyApi, NotificationApi, NotificationtopicApi, PushApi, QrlabelsApi, QrloginApi, QuickpanelApi, ReportApi, RoleApi, RuleApi, SearchApi, SecurityApi, SessionregApi, SettingApi, SsoApi, StationApi, SwipeApi, TagApi, TemplateApi, TermApi, TextcreditApi, TranslationApi, UserApi, UsergroupApi, UsersettingsApi];
