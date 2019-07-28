import { HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Http, Headers, RequestOptions } from '@angular/http';


@Injectable()
export class AuthService {

  BASE_URL = environment.baseurl;
  // BASE_URL = 'http://localhost:53956/api'; // 61646
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
    return localStorage.getItem(this.FIRSTNAME_KEY);
  }
  get reportingday() {
    return localStorage.getItem(this.REPORTINGDAY_KEY);
  }
  get complogo() {
    return localStorage.getItem(this.COMPLOGO_KEY);
  }
  get lastname() {
    return localStorage.getItem(this.LASTNAME_KEY);
  }
  get name() {
    return this.firstname + ' ' + this.lastname;
  }
  get avatar() {
    return localStorage.getItem(this.AVATAR_KEY);
  }

  get role() {
    return localStorage.getItem(this.ROL_KEY);
  }
  get email() {
    return localStorage.getItem(this.EMAIL_KEY);
  }

  get reportingPeriod() {
    return localStorage.getItem(this.FREPPERIOD_KEY);
  }

  get reportingYear() {
    return localStorage.getItem(this.FREPYEAR_KEY);
  }

  get resourceId() {
    return localStorage.getItem(this.RESO_KEY);
  }

  get reportingCurrencySys() {
    return localStorage.getItem(this.CURRENCYSY_KEY);
  }

  get CurrencyShortName() {
    return localStorage.getItem(this.CURRENCYSM_KEY);
  }


  get companyId() {
    return localStorage.getItem(this.COM_KEY);
  }

  get companyName() {
    return localStorage.getItem(this.COM_NAME);
  }


  isTokenAvailable() {
    return !!localStorage.getItem(this.TOKEN_KEY);
  }

  // getToken() {
  //   return this.token;
  // }

  get isAuthenticated() {

    if (this.isTokenAvailable()) {
      return true;
    }
    // here you can check if user is authenticated or not through his token
    return false;
  }

  get tokenHttpClientHeader() {

    const header = new HttpHeaders({'Authorization': 'Bearer ' + localStorage.getItem(this.TOKEN_KEY),
    'Content-Type': 'application/json'});
    return ({headers: header});
  }
  get tokenHeader() {

    const header = new Headers({'Authorization': 'Bearer ' + localStorage.getItem(this.TOKEN_KEY)});
    return new RequestOptions({ headers: header});
  }

  get tokenHeaderWithType() {

    // tslint:disable-next-line:prefer-const
    let options = new RequestOptions();
    options.headers = new Headers();
    options.headers.append('Authorization', 'Bearer ' + localStorage.getItem(this.TOKEN_KEY));
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

          localStorage.setItem(this.FIRSTNAME_KEY, authResponse.firstname);
          localStorage.setItem(this.REPORTINGDAY_KEY, authResponse.reportingday);
          localStorage.setItem(this.COMPLOGO_KEY, authResponse.complogo);
          localStorage.setItem(this.AVATAR_KEY, authResponse.avatar);
          localStorage.setItem(this.LASTNAME_KEY, authResponse.lastname);
          localStorage.setItem(this.TOKEN_KEY, authResponse.token);
          localStorage.setItem(this.COM_KEY, authResponse.comp);
          localStorage.setItem(this.ROL_KEY, authResponse.role);
          localStorage.setItem(this.EMAIL_KEY, authResponse.email);
          localStorage.setItem(this.RESO_KEY, authResponse.resource);
          localStorage.setItem(this. ROL_Group, authResponse.roleGroup);

          localStorage.setItem(this.ALLOWREC_KEY, authResponse.allowRec);
          localStorage.setItem(this.FREPPERIOD_KEY, authResponse.financeRepPeriod);
          localStorage.setItem(this.COM_NAME, authResponse.companyName);
          localStorage.setItem(this.FREPYEAR_KEY, authResponse.financeRepYear);
          localStorage.setItem(this.CURRENCYLN_KEY, authResponse.currencyLongName);
          localStorage.setItem(this.CURRENCYSM_KEY, authResponse.currencyShortName);
          localStorage.setItem(this.CURRENCYSY_KEY, authResponse.currencySymbol);
          localStorage.setItem(this.FREEZEFORE_KEY, authResponse.freezeForecast);
          localStorage.setItem(this.STANDARDHRS_KEY, authResponse.standardDailyHrs);
          localStorage.setItem(this.WORKWEEKEND_KEY, authResponse.doEmployeesWorkWeekends);



          this.router.navigate(['/myprojects/myprojects']);
    });
  }

  logout() {

    this.clearlocalStorage();
    this.router.navigateByUrl('/pages/login');
  }

  clearlocalStorage() {



    localStorage.removeItem(this.FIRSTNAME_KEY);
    localStorage.removeItem(this.REPORTINGDAY_KEY);
    localStorage.removeItem(this.COMPLOGO_KEY);
    localStorage.removeItem(this.AVATAR_KEY);
    localStorage.removeItem(this.LASTNAME_KEY);
    localStorage.removeItem(this.TOKEN_KEY);
    localStorage.removeItem(this.COM_KEY);
    localStorage.removeItem(this.ROL_KEY);
    localStorage.removeItem(this.EMAIL_KEY);
    localStorage.removeItem(this.RESO_KEY);
    localStorage.removeItem(this.ROL_Group);

    localStorage.removeItem(this.ALLOWREC_KEY);
    localStorage.removeItem(this.FREPPERIOD_KEY);
    localStorage.removeItem(this.COM_NAME);
    localStorage.removeItem(this.FREPYEAR_KEY);
    localStorage.removeItem(this.CURRENCYLN_KEY);
    localStorage.removeItem(this.CURRENCYSM_KEY);
    localStorage.removeItem(this.CURRENCYSY_KEY);
    localStorage.removeItem(this.FREEZEFORE_KEY);
    localStorage.removeItem(this.STANDARDHRS_KEY);
    localStorage.removeItem(this.WORKWEEKEND_KEY);

  }

  authenticate(res) {
    const authResponseSerialised = res;
    // const authResponseSerialised = res.json().result;

    // tslint:disable-next-line:curly
    if (!authResponseSerialised.token)
      return;


    localStorage.setItem(this.FIRSTNAME_KEY, authResponseSerialised.firstname);
    localStorage.setItem(this.REPORTINGDAY_KEY, authResponseSerialised.reportingday);
    localStorage.setItem(this.COMPLOGO_KEY, authResponseSerialised.complogo);
    localStorage.setItem(this.AVATAR_KEY, authResponseSerialised.avatar);
    localStorage.setItem(this.LASTNAME_KEY, authResponseSerialised.lastname);
    localStorage.setItem(this.TOKEN_KEY, authResponseSerialised.token);
    localStorage.setItem(this.COM_KEY, authResponseSerialised.comp);
    localStorage.setItem(this.ROL_KEY, authResponseSerialised.role);
    localStorage.setItem(this.EMAIL_KEY, authResponseSerialised.email);
    localStorage.setItem(this.RESO_KEY, authResponseSerialised.resource);
    localStorage.setItem(this. ROL_Group, authResponseSerialised.roleGroup);

    localStorage.setItem(this.ALLOWREC_KEY, authResponseSerialised.allowRec);
    localStorage.setItem(this.FREPPERIOD_KEY, authResponseSerialised.financeRepPeriod);
    localStorage.setItem(this.COM_NAME, authResponseSerialised.companyName);
    localStorage.setItem(this.FREPYEAR_KEY, authResponseSerialised.financeRepYear);
    localStorage.setItem(this.CURRENCYLN_KEY, authResponseSerialised.currencyLongName);
    localStorage.setItem(this.CURRENCYSM_KEY, authResponseSerialised.currencyShortName);
    localStorage.setItem(this.CURRENCYSY_KEY, authResponseSerialised.currencySymbol);
    localStorage.setItem(this.FREEZEFORE_KEY, authResponseSerialised.freezeForecast);
    localStorage.setItem(this.STANDARDHRS_KEY, authResponseSerialised.standardDailyHrs);
    localStorage.setItem(this.WORKWEEKEND_KEY, authResponseSerialised.doEmployeesWorkWeekends);

  }




  isAO() {

    if (localStorage.getItem(this.ROL_KEY) === environment.AccountOwner) {
      return true;
    } else {
      return false;
    }
  }

  isSA() {

    if (localStorage.getItem(this.ROL_KEY) === environment.SeniorProjectManager) {
      return true;
    } else {
      return false;
    }
  }

  isA() {

    if (localStorage.getItem(this.ROL_KEY) === environment.Admin) {
      return true;
    } else {
      return false;
    }
  }

  isPM() {

    if (localStorage.getItem(this.ROL_KEY) === environment.ProjectManager) {
      return true;
    } else {
      return false;
    }
  }

  isSPM() {

    if (localStorage.getItem(this.ROL_KEY) === environment.SeniorProjectManager) {
      return true;
    } else {
      return false;
    }
  }

  isPA() {

    if (localStorage.getItem(this.ROL_KEY) === environment.PortfolioAdmin) {
      return true;
    } else {
      return false;
    }
  }

  isFA() {

    if (localStorage.getItem(this.ROL_KEY) === environment.FinanceAdmin) {
      return true;
    } else {
      return false;
    }
  }

  isFM() {

    if (localStorage.getItem(this.ROL_KEY) === environment.FinanceManager) {
      return true;
    } else {
      return false;
    }
  }

  isRO() {

    if (localStorage.getItem(this.ROL_KEY) === environment.ReadOnly) {
      return true;
    } else {
      return false;
    }
  }
  isPort() {
    const role = localStorage.getItem(this.ROL_KEY);

    if (role === environment.ProjectManager ||
      role === environment.SeniorProjectManager ||
      role === environment.PortfolioAdmin) {
      return true;
    } else {
      return false;
    }
  }

  isTSO() {

    if (localStorage.getItem(this.ROL_KEY) === environment.ReadWriteTimesheetOnly) {
      return true;
    } else {
      return false;
    }
  }

  isSAdmin() {

    const role = localStorage.getItem(this.ROL_KEY);

    if (role === environment.AccountOwner ||
      role === environment.SuperAdmin) {
      return true;
    } else {
      return false;
    }
  }


  isGeneralFinanceAdmin() {

    const role = localStorage.getItem(this.ROL_KEY);

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

    const role = localStorage.getItem(this.ROL_KEY);

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
