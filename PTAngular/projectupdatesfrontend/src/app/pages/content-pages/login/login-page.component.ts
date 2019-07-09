import { Component, ViewChild } from '@angular/core';
import { NgForm, FormBuilder, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from "@angular/router";
import { ILogin } from '../credentials';
import { AuthService } from 'app/shared/auth/auth.service';

@Component({
    selector: 'app-login-page',
    templateUrl: './login-page.component.html',
    styleUrls: ['./login-page.component.scss']
})

export class LoginPageComponent {

    // @ViewChild('f') loginForm: NgForm;
    loginform;
    logincredentials: ILogin;

    constructor(private router: Router, private fb: FormBuilder, private auth: AuthService,
        private route: ActivatedRoute) {
          this.loginform = fb.group({

            userName: ['', Validators.required],
            password: ['', Validators.required],
          });
        }

    // On submit button click
    onSubmit() {

      if (this.loginform.dirty && this.loginform.valid) {
        // tslint:disable-next-line:no-shadowed-variable
        const p = Object.assign({}, this.logincredentials, this.loginform.value);

        console.log(this.loginform.value);
        console.log(this.logincredentials);
        console.log(p);

        this.auth.login(p);

        } else if (!this.loginform.dirty) {
        return;
      }
        // this.loginForm.reset();
    }
    // On Forgot password link click
    onForgotPassword() {
        this.router.navigate(['forgotpassword'], { relativeTo: this.route.parent });
    }
    // On registration link click
    onRegister() {
        this.router.navigate(['register'], { relativeTo: this.route.parent });
    }

    isLogInValid(control) {

      return this.loginform.controls[control].invalid && this.loginform.controls[control].touched;
    }
}
