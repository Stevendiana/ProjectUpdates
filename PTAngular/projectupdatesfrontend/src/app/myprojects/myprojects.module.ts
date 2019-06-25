import { DashboardModule } from 'app/dashboard/dashboard.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MyprojectsRoutingModule } from './myprojects-routing.module';
import { MyprojectsComponent } from './myprojects.component';

@NgModule({
  declarations: [MyprojectsComponent],
  imports: [
    CommonModule,
    DashboardModule,
    MyprojectsRoutingModule
  ]
})
export class MyprojectsModule { }
// export const routedComponents = [MyprojectsComponent];
