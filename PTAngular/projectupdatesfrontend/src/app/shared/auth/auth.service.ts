import { Router } from '@angular/router';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Http, Headers, RequestOptions } from '@angular/http';


@Injectable()
export class AuthService {

  BASE_URL = 'http://localhost:53956/api'; // 61646
  // BASE_URL = 'https://myprojectapplicationbackend.azurewebsites.net/api';
  TOKEN_KEY = 'token';
  FIRSTNAME_KEY = 'firstname';
  AVATAR_KEY = 'avatar';
  LASTNAME_KEY = 'lastname';
  COM_KEY = 'comp';
  COM_NAME = 'companyName';
  ROL_KEY = 'role';
  EMAIL_KEY = 'email';
  ROL_Group = 'roleGroup';
  REPORTINGDAY_KEY = 'reportingday';
  COMPLOGO_KEY = 'complogo';

  RESO_KEY = 'resource';
  ALLOWREC_KEY = 'allowRec';
  FREPPERIOD_KEY = 'financeRepPeriod';
  FREPYEAR_KEY = 'financeRepYear';
  CURRENCYLN_KEY = 'currencyLongName';
  CURRENCYSM_KEY = 'currencyShortName';
  CURRENCYSY_KEY = 'currencySymbol';
  FREEZEFORE_KEY = 'freezeForecast';
  STANDARDHRS_KEY = 'standardDailyHrs';
  WORKWEEKEND_KEY = 'doEmployeesWorkWeekends';


  constructor(private http: Http, private router: Router) { }


  get firstname() {
    return sessionStorage.getItem(this.FIRSTNAME_KEY);
  }
  get reportingday() {
    return sessionStorage.getItem(this.REPORTINGDAY_KEY);
  }
  get complogo() {
    return sessionStorage.getItem(this.COMPLOGO_KEY);
  }
  get lastname() {
    return sessionStorage.getItem(this.LASTNAME_KEY);
  }
  get name() {
    return this.firstname + ' ' + this.lastname;
  }
  get avatar() {
    return sessionStorage.getItem(this.AVATAR_KEY);
  }

  get role() {
    return sessionStorage.getItem(this.ROL_KEY);
  }
  get email() {
    return sessionStorage.getItem(this.EMAIL_KEY);
  }

  get reportingPeriod() {
    return sessionStorage.getItem(this.FREPPERIOD_KEY);
  }

  get reportingYear() {
    return sessionStorage.getItem(this.FREPYEAR_KEY);
  }

  get resourceId() {
    return sessionStorage.getItem(this.RESO_KEY);
  }

  get reportingCurrencySys() {
    return sessionStorage.getItem(this.CURRENCYSY_KEY);
  }

  get CurrencyShortName() {
    return sessionStorage.getItem(this.CURRENCYSM_KEY);
  }


  get companyId() {
    return sessionStorage.getItem(this.COM_KEY);
  }

  get companyName() {
    return sessionStorage.getItem(this.COM_NAME);
  }


  getToken() {
    return !!sessionStorage.getItem(this.TOKEN_KEY);
  }

  // getToken() {
  //   return this.token;
  // }

  get isAuthenticated() {

    if (this.getToken()) {
      return true;
    }
    // here you can check if user is authenticated or not through his token
    return false;
  }

  get tokenHeader() {

    const header = new Headers({'Authorization': 'Bearer ' + sessionStorage.getItem(this.TOKEN_KEY)});
    return new RequestOptions({ headers: header});
  }

  get tokenHeaderWithType() {

    // tslint:disable-next-line:prefer-const
    let options = new RequestOptions();
    options.headers = new Headers();
    options.headers.append('Authorization', 'Bearer ' + sessionStorage.getItem(this.TOKEN_KEY));
    options.headers.append('Content-Type', 'application/json; charset=utf-8');

    return options;
  }

  login(loginData) {

    this.http.post(this.BASE_URL + '/auth/login', loginData).subscribe(res => {
      console.log(res.json());
      this.authenticate(res.json());
      this.router.navigate(['/myprojects/myprojects']);
      // window.location.reload();
    });
  }

  addResource(newresource) {

    delete newresource.confirmPassword;
    this.http.post(this.BASE_URL + '/addresource', newresource).subscribe();
  }


  register(user) {

    delete user.confirmPassword;
    this.http.post(this.BASE_URL + '/auth/register', user).subscribe(res => {


      // tslint:disable-next-line:prefer-const
      let authResponse = res.json();


          // tslint:disable-next-line:curly
          if (!authResponse.token)
            return;

          sessionStorage.setItem(this.FIRSTNAME_KEY, authResponse.firstname);
          sessionStorage.setItem(this.REPORTINGDAY_KEY, authResponse.reportingday);
          sessionStorage.setItem(this.COMPLOGO_KEY, authResponse.complogo);
          sessionStorage.setItem(this.AVATAR_KEY, authResponse.avatar);
          sessionStorage.setItem(this.LASTNAME_KEY, authResponse.lastname);
          sessionStorage.setItem(this.TOKEN_KEY, authResponse.token);
          sessionStorage.setItem(this.COM_KEY, authResponse.comp);
          sessionStorage.setItem(this.ROL_KEY, authResponse.role);
          sessionStorage.setItem(this.EMAIL_KEY, authResponse.email);
          sessionStorage.setItem(this.RESO_KEY, authResponse.resource);
          sessionStorage.setItem(this. ROL_Group, authResponse.roleGroup);

          sessionStorage.setItem(this.ALLOWREC_KEY, authResponse.allowRec);
          sessionStorage.setItem(this.FREPPERIOD_KEY, authResponse.financeRepPeriod);
          sessionStorage.setItem(this.COM_NAME, authResponse.companyName);
          sessionStorage.setItem(this.FREPYEAR_KEY, authResponse.financeRepYear);
          sessionStorage.setItem(this.CURRENCYLN_KEY, authResponse.currencyLongName);
          sessionStorage.setItem(this.CURRENCYSM_KEY, authResponse.currencyShortName);
          sessionStorage.setItem(this.CURRENCYSY_KEY, authResponse.currencySymbol);
          sessionStorage.setItem(this.FREEZEFORE_KEY, authResponse.freezeForecast);
          sessionStorage.setItem(this.STANDARDHRS_KEY, authResponse.standardDailyHrs);
          sessionStorage.setItem(this.WORKWEEKEND_KEY, authResponse.doEmployeesWorkWeekends);



          this.router.navigate(['/myprojects/myprojects']);
    });
  }

  logout() {

    this.clearsessionStorage();
    this.router.navigateByUrl('/pages/login');
  }

  clearsessionStorage() {



    sessionStorage.removeItem(this.FIRSTNAME_KEY);
    sessionStorage.removeItem(this.REPORTINGDAY_KEY);
    sessionStorage.removeItem(this.COMPLOGO_KEY);
    sessionStorage.removeItem(this.AVATAR_KEY);
    sessionStorage.removeItem(this.LASTNAME_KEY);
    sessionStorage.removeItem(this.TOKEN_KEY);
    sessionStorage.removeItem(this.COM_KEY);
    sessionStorage.removeItem(this.ROL_KEY);
    sessionStorage.removeItem(this.EMAIL_KEY);
    sessionStorage.removeItem(this.RESO_KEY);
    sessionStorage.removeItem(this.ROL_Group);

    sessionStorage.removeItem(this.ALLOWREC_KEY);
    sessionStorage.removeItem(this.FREPPERIOD_KEY);
    sessionStorage.removeItem(this.COM_NAME);
    sessionStorage.removeItem(this.FREPYEAR_KEY);
    sessionStorage.removeItem(this.CURRENCYLN_KEY);
    sessionStorage.removeItem(this.CURRENCYSM_KEY);
    sessionStorage.removeItem(this.CURRENCYSY_KEY);
    sessionStorage.removeItem(this.FREEZEFORE_KEY);
    sessionStorage.removeItem(this.STANDARDHRS_KEY);
    sessionStorage.removeItem(this.WORKWEEKEND_KEY);

  }

  authenticate(res) {
    const authResponseSerialised = res;
    // const authResponseSerialised = res.json().result;

    // tslint:disable-next-line:curly
    if (!authResponseSerialised.token)
      return;


    sessionStorage.setItem(this.FIRSTNAME_KEY, authResponseSerialised.firstname);
    sessionStorage.setItem(this.REPORTINGDAY_KEY, authResponseSerialised.reportingday);
    sessionStorage.setItem(this.COMPLOGO_KEY, authResponseSerialised.complogo);
    sessionStorage.setItem(this.AVATAR_KEY, authResponseSerialised.avatar);
    sessionStorage.setItem(this.LASTNAME_KEY, authResponseSerialised.lastname);
    sessionStorage.setItem(this.TOKEN_KEY, authResponseSerialised.token);
    sessionStorage.setItem(this.COM_KEY, authResponseSerialised.comp);
    sessionStorage.setItem(this.ROL_KEY, authResponseSerialised.role);
    sessionStorage.setItem(this.EMAIL_KEY, authResponseSerialised.email);
    sessionStorage.setItem(this.RESO_KEY, authResponseSerialised.resource);
    sessionStorage.setItem(this. ROL_Group, authResponseSerialised.roleGroup);

    sessionStorage.setItem(this.ALLOWREC_KEY, authResponseSerialised.allowRec);
    sessionStorage.setItem(this.FREPPERIOD_KEY, authResponseSerialised.financeRepPeriod);
    sessionStorage.setItem(this.COM_NAME, authResponseSerialised.companyName);
    sessionStorage.setItem(this.FREPYEAR_KEY, authResponseSerialised.financeRepYear);
    sessionStorage.setItem(this.CURRENCYLN_KEY, authResponseSerialised.currencyLongName);
    sessionStorage.setItem(this.CURRENCYSM_KEY, authResponseSerialised.currencyShortName);
    sessionStorage.setItem(this.CURRENCYSY_KEY, authResponseSerialised.currencySymbol);
    sessionStorage.setItem(this.FREEZEFORE_KEY, authResponseSerialised.freezeForecast);
    sessionStorage.setItem(this.STANDARDHRS_KEY, authResponseSerialised.standardDailyHrs);
    sessionStorage.setItem(this.WORKWEEKEND_KEY, authResponseSerialised.doEmployeesWorkWeekends);

  }




  isAO() {

    if (sessionStorage.getItem(this.ROL_KEY) === environment.AccountOwner) {
      return true;
    } else {
      return false;
    }
  }

  isSA() {

    if (sessionStorage.getItem(this.ROL_KEY) === environment.SeniorProjectManager) {
      return true;
    } else {
      return false;
    }
  }

  isA() {

    if (sessionStorage.getItem(this.ROL_KEY) === environment.Admin) {
      return true;
    } else {
      return false;
    }
  }

  isPM() {

    if (sessionStorage.getItem(this.ROL_KEY) === environment.ProjectManager) {
      return true;
    } else {
      return false;
    }
  }

  isSPM() {

    if (sessionStorage.getItem(this.ROL_KEY) === environment.SeniorProjectManager) {
      return true;
    } else {
      return false;
    }
  }

  isPA() {

    if (sessionStorage.getItem(this.ROL_KEY) === environment.PortfolioAdmin) {
      return true;
    } else {
      return false;
    }
  }

  isFA() {

    if (sessionStorage.getItem(this.ROL_KEY) === environment.FinanceAdmin) {
      return true;
    } else {
      return false;
    }
  }

  isFM() {

    if (sessionStorage.getItem(this.ROL_KEY) === environment.FinanceManager) {
      return true;
    } else {
      return false;
    }
  }

  isRO() {

    if (sessionStorage.getItem(this.ROL_KEY) === environment.ReadOnly) {
      return true;
    } else {
      return false;
    }
  }
  isPort() {
    const role = sessionStorage.getItem(this.ROL_KEY);

    if (role === environment.ProjectManager ||
      role === environment.SeniorProjectManager ||
      role === environment.PortfolioAdmin) {
      return true;
    } else {
      return false;
    }
  }

  isTSO() {

    if (sessionStorage.getItem(this.ROL_KEY) === environment.ReadWriteTimesheetOnly) {
      return true;
    } else {
      return false;
    }
  }

  isSAdmin() {

    const role = sessionStorage.getItem(this.ROL_KEY);

    if (role === environment.AccountOwner ||
      role === environment.SuperAdmin) {
      return true;
    } else {
      return false;
    }
  }


  isGeneralFinanceAdmin() {

    const role = sessionStorage.getItem(this.ROL_KEY);

    if (role === environment.AccountOwner ||
        role === environment.SuperAdmin ||
        role === environment.FinanceAdmin ||
        role === environment.FinanceManager
      ) {
      return true;
    } else {
      return false;
    }
  }

  isFin() {

    const role = sessionStorage.getItem(this.ROL_KEY);

    if (role === environment.FinanceAdmin ||
      role === environment.FinanceManager) {
      return true;
    } else {
      return false;
    }
  }

  // token: string;

  // constructor() {}

  // signupUser(email: string, password: string) {
  //   //your code for signing up the new user
  // }

  // signinUser(email: string, password: string) {
  //   //your code for checking credentials and getting tokens for for signing in user
  // }

  // logout() {
  //   this.token = null;
  // }


}
