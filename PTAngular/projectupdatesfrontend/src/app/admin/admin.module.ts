import { AdminRoutingModule } from './admin-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HierarchyComponent } from './hierarchy/hierarchy.component';
import { DomainComponent } from './domain/domain.component';
import { BusinessunitComponent } from './businessunit/businessunit.component';
import { PortfolioComponent } from './portfolio/portfolio.component';
import { ProgrammeComponent } from './programme/programme.component';
import { ProjectComponent } from './project/project.component';
import { ResourceComponent } from './resource/resource.component';
import { ResourceResourceComponent } from './resource-resource/resource-resource.component';
import { ResourcePlatformComponent } from './resource-platform/resource-platform.component';
import { ResourceUserComponent } from './resource-user/resource-user.component';
import { UploadCentreComponent } from './upload-centre/upload-centre.component';
import { UploadCentreActualComponent } from './upload-centre-actual/upload-centre-actual.component';
import { CompanSettingsComponent } from './compan-settings/compan-settings.component';
import { ChartistModule } from 'ng-chartist';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MatchHeightModule } from 'app/shared/directives/match-height.directive';

@NgModule({
  declarations: [
    HierarchyComponent, DomainComponent, BusinessunitComponent,
    PortfolioComponent, ProgrammeComponent, ProjectComponent, ResourceComponent,
    ResourceResourceComponent, ResourcePlatformComponent, ResourceUserComponent,
    UploadCentreComponent, UploadCentreActualComponent, CompanSettingsComponent],
  imports: [
    CommonModule,
    AdminRoutingModule,
    ChartistModule,
    NgbModule,
    MatchHeightModule
]
})
export class AdminModule { }
