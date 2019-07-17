import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ResourcesComponent } from './resources/resources.component';
import { ResourcesRoutingModule } from './resources-routing.module';
import { SharedModule } from 'app/shared/shared.module';
import { ChartistModule } from 'ng-chartist';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MatchHeightModule } from 'app/shared/directives/match-height.directive';
import { ResourcesAvailabilityComponent } from './resources-availability/resources-availability.component';
import { ResourcesUtilizationComponent } from './resources-utilization/resources-utilization.component';
import { ResourcesDemandComponent } from './resources-demand/resources-demand.component';
import { ResourcesAvailabilityTableComponent } from './resources-availability-table/resources-availability-table.component';
import { ResourcesDemandTableComponent } from './resources-demand-table/resources-demand-table.component';
import { ResourcesUtilizationTableComponent } from './resources-utilization-table/resources-utilization-table.component';
import { ResourcesAbsencesComponent } from './resources-absences/resources-absences.component';
import { ResourcesAbsencesTableComponent } from './resources-absences-table/resources-absences-table.component';
import { ResourceAbsencesTableComponent } from './resource/resource-absences-table/resource-absences-table.component';
import { ResourceAbsencesComponent } from './resource/resource-absences/resource-absences.component';
import { ResourceDemandComponent } from './resource/resource-demand/resource-demand.component';
import { ResourceDemandTableComponent } from './resource/resource-demand-table/resource-demand-table.component';
import { ResourceAvailabilityTableComponent } from './resource/resource-availability-table/resource-availability-table.component';
import { ResourceAvailabilityComponent } from './resource/resource-availability/resource-availability.component';
import { ResourceUtilizationComponent } from './resource/resource-utilization/resource-utilization.component';
import { ResourceUtilizationTableComponent } from './resource/resource-utilization-table/resource-utilization-table.component';
import { ResourceService } from './resources.service';
import { EditResourceComponent } from './resource/edit-resource.component';
import { DeleteResourceComponent } from './resource/delete-resource.component';
import { ResourcesDashboardComponent } from './resources-dashboard/resources-dashboard.component';
import { ResourceComponent } from './resource/resource.component';

@NgModule({
  declarations: [ResourcesComponent, ResourceComponent,
    ResourcesAvailabilityComponent, ResourcesUtilizationComponent, ResourcesDemandComponent,
    ResourcesAvailabilityTableComponent, ResourcesDemandTableComponent, ResourcesUtilizationTableComponent,
    ResourcesAbsencesTableComponent, ResourceAbsencesTableComponent, ResourceAbsencesComponent, ResourceDemandComponent,
    ResourceAvailabilityTableComponent, ResourceAvailabilityComponent, ResourceUtilizationComponent, ResourceUtilizationTableComponent,
    EditResourceComponent, DeleteResourceComponent, ResourcesDashboardComponent],
  imports: [
    CommonModule,
    ResourcesRoutingModule,
    CommonModule,
    SharedModule,
    ChartistModule,
    NgbModule,
    MatchHeightModule
  ],
  entryComponents: [
                    EditResourceComponent,
                    DeleteResourceComponent ],
  providers: [ResourceService]
})
export class ResourcesModule { }
