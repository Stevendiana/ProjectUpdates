import { HttpClient, HttpClientModule } from '@angular/common/http';
// import { SearchPipe } from 'app/shared/pipes/search.pipe';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { QuillModule } from 'ngx-quill'
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { FormsModule } from '@angular/forms';

import { TimesheetsRoutingModule } from './timesheets-routing.module';

import { TimesheetsComponent } from './timesheets.component';
import { InboxModule } from 'app/inbox/inbox.module';
import { TimesheetsService } from './timesheets.service';
import { HttpModule } from '@angular/http';



@NgModule({
    imports: [
        CommonModule,
        HttpClientModule,
        HttpModule,
        TimesheetsRoutingModule,
        NgbModule,
        QuillModule,
        FormsModule,
        InboxModule,
        PerfectScrollbarModule
    ],
    declarations: [
      TimesheetsComponent,
        // SearchPipe
    ],
    providers: [TimesheetsService]
})
export class TimesheetsModule { }
