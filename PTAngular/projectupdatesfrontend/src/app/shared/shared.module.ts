import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { DataTablesModule } from 'angular-datatables';
import { DataTableModule } from 'angular-6-datatable';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TranslateModule } from '@ngx-translate/core';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';

// COMPONENTS
import { FooterComponent } from './footer/footer.component';
import { NavbarComponent } from './navbar/navbar.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { CustomizerComponent } from './customizer/customizer.component';
import { NotificationSidebarComponent } from './notification-sidebar/notification-sidebar.component';

// DIRECTIVES
import { ToggleFullscreenDirective } from './directives/toggle-fullscreen.directive';
import { SidebarDirective } from './directives/sidebar.directive';
import { SidebarLinkDirective } from './directives/sidebarlink.directive';
import { SidebarListDirective } from './directives/sidebarlist.directive';
import { SidebarAnchorToggleDirective } from './directives/sidebaranchortoggle.directive';
import { SidebarToggleDirective } from './directives/sidebartoggle.directive';
import { FlPipe } from 'app/app.fl';
import { CountoModule } from 'angular2-counto';
import { NGXToastrService } from './toastr.service';

@NgModule({
    exports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        FooterComponent,
        NavbarComponent,
        SidebarComponent,
        CustomizerComponent,
        DataTablesModule,
        DataTableModule,
        CountoModule,
        NotificationSidebarComponent,
        ToggleFullscreenDirective,
        SidebarDirective,
        NgbModule,
        FlPipe,
        PerfectScrollbarModule,
        TranslateModule
    ],
    imports: [
        RouterModule,
        CommonModule,
        CountoModule,
        FormsModule,
        ReactiveFormsModule,
        NgbModule,
        DataTablesModule,
        DataTableModule,
        TranslateModule,
        PerfectScrollbarModule
    ],
    declarations: [
        FlPipe,
        FooterComponent,
        NavbarComponent,
        SidebarComponent,
        CustomizerComponent,
        NotificationSidebarComponent,
        ToggleFullscreenDirective,
        SidebarDirective,
        SidebarLinkDirective,
        SidebarListDirective,
        SidebarAnchorToggleDirective,
        SidebarToggleDirective
    ],
    providers: [NGXToastrService]
})
export class SharedModule { }
