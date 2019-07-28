import { IRateCardUI } from './rate-card';

export interface IRateCard {

  companyId: string;
  companyRateCardId: string;
  companyRateCardCode: string;
  employeeJobTitleOrGradeOrBand: string;
  locationForGradeOnshoreOffShore: string;
  isContractor: boolean;
  dailyRate: number;

}
export interface IRateCardUI {

  companyId: string;
  companyRateCardId: string;
  companyRateCardCode: string;
  employeeJobTitleOrGradeOrBand: string;
  locationForGradeOnshoreOffShore: string;
  isContractor: boolean;
  dailyRate: number;
  resourceRatecardDisplayname: string;

}

export class RateCard {

  companyId: string;
  companyRateCardId: string;
  companyRateCardCode: string;
  employeeJobTitleOrGradeOrBand: string;
  locationForGradeOnshoreOffShore: string;
  isContractor: boolean;
  dailyRate: number;
  resourceRatecardDisplayname: string;

  }


