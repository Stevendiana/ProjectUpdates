import { SharedModule } from './../shared/shared.module';
import { DashboardModule } from 'app/dashboard/dashboard.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MyprojectsRoutingModule } from './myprojects-routing.module';
import { MyprojectsComponent } from './myprojects.component';
import { ChartistModule } from 'ng-chartist';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MatchHeightModule } from 'app/shared/directives/match-height.directive';

@NgModule({
  declarations: [MyprojectsComponent],
  imports: [
    CommonModule,
    SharedModule,
    MyprojectsRoutingModule,
    ChartistModule,
    NgbModule,
    MatchHeightModule
  ],
  exports: [MyprojectsComponent],
})
export class MyprojectsModule { }

