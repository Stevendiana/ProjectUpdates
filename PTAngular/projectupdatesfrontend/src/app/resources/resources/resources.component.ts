import { value } from './../../shared/data/dropdowns';
import { AuthService } from 'app/shared/auth/auth.service';
import { Router } from '@angular/router';
import { element } from 'protractor';
import { Subject } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { Component, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { ChartEvent, ChartType } from 'ng-chartist';
import * as Chartist from 'chartist';
import { ResourceService } from '../resources.service';
import { Resource, IResource, IResourceList } from '../resource';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { DataTableDirective } from 'angular-datatables';
import { DeleteResourceComponent } from '../resource/delete-resource.component';
import { EditResourceComponent } from '../resource/edit-resource.component';
import { ResourceComponent } from 'app/resources/resource/resource.component';
import { IRateCard } from '../rate-card';
import { IResourceUtilization, ResourceUtilization } from '../resource-utility';

declare var require: any;

const data: any = require('../../shared/data/chartist.json');

export interface Chart {
    type: ChartType;
    data: Chartist.IChartistData;
    options?: any;
    responsiveOptions?: any;
    events?: ChartEvent;
}

@Component({
  selector: 'app-resources',
  templateUrl: './resources.component.html',
  styleUrls: ['./resources.component.scss'],
  // encapsulation: ViewEncapsulation.None,
})
export class ResourcesComponent implements OnInit {

  resources$ = new Subject<any>();
  resources: IResourceList[]  = [];
  ratecards: IRateCard[] = [];
  util: IResourceUtilization;
  ut: IResourceUtilization[] = [];
  // res: IResourceList;
  resourceCount: number;
  search: string;
  errorMessage: string;
  pagelenght = 25;
  closeResult: string;
  data: any;
  currentmonthdays = 23;
  showin = 'days';


  example: any;

  // Line chart configuration Starts
  WidgetlineChart: Chart = {
    type: 'Line', data: data['WidgetlineChart2'],
    options: {
        axisX: {
            showGrid: false,
            showLabel: false,
            offset: 0,
        },
        axisY: {
            showGrid: false,
            low: 50,
            showLabel: false,
            offset: 0,
        },
        fullWidth: true
    },
  };
  // Line chart configuration Ends

  // Line chart configuration Starts
  WidgetlineChart1: Chart = {
    type: 'Line', data: data['WidgetlineChart3'],
    options: {
        axisX: {
            showGrid: false,
            showLabel: false,
            offset: 0,
        },
        axisY: {
            showGrid: false,
            low: 50,
            showLabel: false,
            offset: 0,
        },
        fullWidth: true,
        chartPadding: { top: 0, right: 0, bottom: 10, left: 0 }
    },
    events: {
        created(data: any): void {

            const defs = data.svg.elem('defs');
            defs.elem('linearGradient', {
                id: 'widgradient',
                x1: 0,
                y1: 1,
                x2: 0,
                y2: 0
            }).elem('stop', {
                offset: 0,
                'stop-color': 'rgba(132, 60, 247, 1)'
            }).parent().elem('stop', {
                offset: 1,
                'stop-color': 'rgba(56, 184, 242, 1)'
            });

        },

    },
  };
  // Line chart configuration Ends

  // Line chart configuration Starts
  WidgetlineChart2: Chart = {
    type: 'Line', data: data['WidgetlineChart'],
    options: {
        axisX: {
            showGrid: true,
            showLabel: false,
            offset: 0,
        },
        axisY: {
            showGrid: false,
            low: 40,
            showLabel: false,
            offset: 0,
        },
        lineSmooth: Chartist.Interpolation.cardinal({
            tension: 0
        }),
        fullWidth: true
    },
    events: {
        created(data: any): void {

            const defs = data.svg.elem('defs');
            defs.elem('linearGradient', {
                id: 'widgradient1',
                x1: 0,
                y1: 1,
                x2: 0,
                y2: 0
            }).elem('stop', {
                offset: 0,
                'stop-color': 'rgba(0, 201, 255,1)'
            }).parent().elem('stop', {
                offset: 1,
                'stop-color': 'rgba(17,228,183, 1)'
            });
        },

    },
  };
  // Line chart configuration Ends

  // Donut chart configuration Starts
  DonutChart1: Chart = {
    type: 'Pie',
    data: data['DashboardDonut'],
    options: {
        donut: true,
        donutWidth: 3,
        startAngle: 0,
        chartPadding: 25,
        labelInterpolationFnc: function (value) {
            return '\ue9c9';
        }
    },
    events: {
        draw(data: any): void {
            if (data.type === 'label') {
                if (data.index === 0) {
                    data.element.attr({
                        dx: data.element.root().width() / 2,
                        dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                        class: 'ct-label',
                        'font-family': 'feather'
                    });
                } else {
                    data.element.remove();
                }
            }
        }
    }
  };
  // Donut chart configuration Ends

  // Donut chart configuration Starts
  DonutChart2: Chart = {
    type: 'Pie',
    data: data['DashboardDonut'],
    options: {
        donut: true,
        donutWidth: 3,
        startAngle: 90,
        chartPadding: 25,
        labelInterpolationFnc: function (value) {
            return '\ue9e7';
        }
    },
    events: {
        draw(data: any): void {
            if (data.type === 'label') {
                if (data.index === 0) {
                    data.element.attr({
                        dx: data.element.root().width() / 2,
                        dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                        class: 'ct-label',
                        'font-family': 'feather'
                    });
                } else {
                    data.element.remove();
                }
            }
        }
    }
  };
  // Donut chart configuration Ends

  // Donut chart configuration Starts
  DonutChart3: Chart = {
    type: 'Pie',
    data: data['DashboardDonut'],
    options: {
        donut: true,
        donutWidth: 3,
        startAngle: 270,
        chartPadding: 25,
        labelInterpolationFnc: function (value) {
            return '\ue964';
        }
    },
    events: {
        draw(data: any): void {
            if (data.type === 'label') {
                if (data.index === 0) {
                    data.element.attr({
                        dx: data.element.root().width() / 2,
                        dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                        class: 'ct-label',
                        'font-family': 'feather'
                    });
                } else {
                    data.element.remove();
                }
            }
        }
    }
  };
  // Donut chart configuration Ends

  // Line area chart configuration Starts
  lineAreaChart: Chart = {
    type: 'Line',
    data: data['lineArea3'],
    options: {
        low: 0,
        showArea: true,
        fullWidth: true,
        onlyInteger: true,
        axisY: {
            low: 0,
            scaleMinSpace: 50,
        },
        axisX: {
            showGrid: false
        }
    },
    events: {
        created(data: any): void {
            const defs = data.svg.elem('defs');
            defs.elem('linearGradient', {
                id: 'gradient',
                x1: 0,
                y1: 1,
                x2: 0,
                y2: 0
            }).elem('stop', {
                offset: 0,
                'stop-opacity': '0.2',
                'stop-color': 'rgba(255, 255, 255, 1)'
            }).parent().elem('stop', {
                offset: 1,
                'stop-opacity': '0.2',
                'stop-color': 'rgba(38, 198, 218, 1)'
            });
        },
        draw(data: any): void {

            const circleRadius = 6;
            if (data.type === 'point') {
                const circle = new Chartist.Svg('circle', {
                    cx: data.x,
                    cy: data.y,
                    r: circleRadius,
                    class: 'ct-point-circle'
                });
                data.element.replace(circle);
            }
        }
    },
  };
  // Line area chart configuration Ends

  // Line chart configuration Starts
  lineChart2: Chart = {
    type: 'Line', data: data['line2'],
    options: {
        axisX: {
            showGrid: false,
        },
        axisY: {
            low: 0,
            scaleMinSpace: 50,
        },
        fullWidth: true,
    },
    responsiveOptions: [
        ['screen and (max-width: 640px) and (min-width: 381px)', {
            axisX: {
                labelInterpolationFnc: function (value, index) {
                    return index % 2 === 0 ? value : null;
                }
            }
        }],
        ['screen and (max-width: 380px)', {
            axisX: {
                labelInterpolationFnc: function (value, index) {
                    return index % 3 === 0 ? value : null;
                }
            }
        }]
    ],
    events: {
        draw(data: any): void {
            const circleRadius = 6;
            if (data.type === 'point') {
                const circle = new Chartist.Svg('circle', {
                    cx: data.x,
                    cy: data.y,
                    r: circleRadius,
                    class: 'ct-point-circle'
                });
                data.element.replace(circle);
            } else if (data.type === 'label') {
                // adjust label position for rotation
                const dX = data.width / 2 + (30 - data.width)
                data.element.attr({ x: data.element.attr('x') - dX })
            }
        }
    },

  };
  // Line chart configuration Ends

  // Line chart configuration Starts
  lineChart1: Chart = {
    type: 'Line', data: data['line1'],
    options: {
        axisX: {
            showGrid: false,
        },
        axisY: {
            low: 0,
            scaleMinSpace: 50,
        },
        fullWidth: true
    },
    events: {
        draw(data: any): void {
            if (data.type === 'label') {
                // adjust label position for rotation
                const dX = data.width / 2 + (30 - data.width)
                data.element.attr({ x: data.element.attr('x') - dX })
            }
        }
    },
  };
  // Line chart configuration Ends
    // Line area chart configuration Starts
    lineArea: Chart = {
      type: 'Line',
      data: data['lineAreaDashboard'],
      options: {
          low: 0,
          showArea: true,
          fullWidth: true,
          onlyInteger: true,
          axisY: {
              low: 0,
              scaleMinSpace: 50,
          },
          axisX: {
              showGrid: false
          }
      },
      events: {
          created(data: any): void {
              const defs = data.svg.elem('defs');
              defs.elem('linearGradient', {
                  id: 'gradient',
                  x1: 0,
                  y1: 1,
                  x2: 1,
                  y2: 0
              }).elem('stop', {
                  offset: 0,
                  'stop-color': 'rgba(0, 201, 255, 1)'
              }).parent().elem('stop', {
                  offset: 1,
                  'stop-color': 'rgba(146, 254, 157, 1)'
              });

              defs.elem('linearGradient', {
                  id: 'gradient1',
                  x1: 0,
                  y1: 1,
                  x2: 1,
                  y2: 0
              }).elem('stop', {
                  offset: 0,
                  'stop-color': 'rgba(132, 60, 247, 1)'
              }).parent().elem('stop', {
                  offset: 1,
                  'stop-color': 'rgba(56, 184, 242, 1)'
              });
          },

      },
  };
  // Line area chart configuration Ends

  // Stacked Bar chart configuration Starts
  Stackbarchart: Chart = {
      type: 'Bar',
      data: data['Stackbarchart'],
      options: {
          stackBars: true,
          fullWidth: true,
          axisX: {
              showGrid: false,
          },
          axisY: {
              showGrid: false,
              showLabel: false,
              offset: 0
          },
          chartPadding: 30
      },
      events: {
          created(data: any): void {
              const defs = data.svg.elem('defs');
              defs.elem('linearGradient', {
                  id: 'linear',
                  x1: 0,
                  y1: 1,
                  x2: 0,
                  y2: 0
              }).elem('stop', {
                  offset: 0,
                  'stop-color': 'rgba(0, 201, 255,1)'
              }).parent().elem('stop', {
                  offset: 1,
                  'stop-color': 'rgba(17,228,183, 1)'
              });
          },
          draw(data: any): void {
              if (data.type === 'bar') {
                  data.element.attr({
                      style: 'stroke-width: 5px',
                      x1: data.x1 + 0.001
                  });

              } else if (data.type === 'label') {
                  data.element.attr({
                      y: 270
                  })
              }
          }
      },
  };
  // Stacked Bar chart configuration Ends

  // Line area chart 2 configuration Starts
  lineArea2: Chart = {
      type: 'Line',
      data: data['lineArea2'],
      options: {
          showArea: true,
          fullWidth: true,
          lineSmooth: Chartist.Interpolation.none(),
          axisX: {
              showGrid: false,
          },
          axisY: {
              low: 0,
              scaleMinSpace: 50,
          }
      },
      responsiveOptions: [
          ['screen and (max-width: 640px) and (min-width: 381px)', {
              axisX: {
                  labelInterpolationFnc: function (value, index) {
                      return index % 2 === 0 ? value : null;
                  }
              }
          }],
          ['screen and (max-width: 380px)', {
              axisX: {
                  labelInterpolationFnc: function (value, index) {
                      return index % 3 === 0 ? value : null;
                  }
              }
          }]
      ],
      events: {
          created(data: any): void {
              const defs = data.svg.elem('defs');
              defs.elem('linearGradient', {
                  id: 'gradient2',
                  x1: 0,
                  y1: 1,
                  x2: 0,
                  y2: 0
              }).elem('stop', {
                  offset: 0,
                  'stop-opacity': '0.2',
                  'stop-color': 'rgba(255, 255, 255, 1)'
              }).parent().elem('stop', {
                  offset: 1,
                  'stop-opacity': '0.2',
                  'stop-color': 'rgba(0, 201, 255, 1)'
              });

              defs.elem('linearGradient', {
                  id: 'gradient3',
                  x1: 0,
                  y1: 1,
                  x2: 0,
                  y2: 0
              }).elem('stop', {
                  offset: 0.3,
                  'stop-opacity': '0.2',
                  'stop-color': 'rgba(255, 255, 255, 1)'
              }).parent().elem('stop', {
                  offset: 1,
                  'stop-opacity': '0.2',
                  'stop-color': 'rgba(132, 60, 247, 1)'
              });
          },
          draw(data: any): void {
              const circleRadius = 4;
              if (data.type === 'point') {

                  const circle = new Chartist.Svg('circle', {
                      cx: data.x,
                      cy: data.y,
                      r: circleRadius,
                      class: 'ct-point-circle'
                  });
                  data.element.replace(circle);
              } else if (data.type === 'label') {
                  // adjust label position for rotation
                  const dX = data.width / 2 + (30 - data.width)
                  data.element.attr({ x: data.element.attr('x') - dX })
              }
          }
      },
  };
  // Line area chart 2 configuration Ends

  // Line chart configuration Starts
  lineChart: Chart = {
      type: 'Line', data: data['LineDashboard'],
      options: {
          axisX: {
              showGrid: false
          },
          axisY: {
              showGrid: false,
              showLabel: false,
              low: 0,
              high: 100,
              offset: 0,
          },
          fullWidth: true,
          offset: 0,
      },
      events: {
          draw(data: any): void {
              const circleRadius = 4;
              if (data.type === 'point') {
                  const circle = new Chartist.Svg('circle', {
                      cx: data.x,
                      cy: data.y,
                      r: circleRadius,
                      class: 'ct-point-circle'
                  });

                  data.element.replace(circle);
              } else if (data.type === 'label') {
                  // adjust label position for rotation
                  const dX = data.width / 2 + (30 - data.width)
                  data.element.attr({ x: data.element.attr('x') - dX })
              }
          }
      },

  };
  // Line chart configuration Ends

  // Donut chart configuration Starts
  DonutChart: Chart = {
      type: 'Pie',
      data: data['donutDashboard'],
      options: {
          donut: true,
          startAngle: 0,
          labelInterpolationFnc: function (value) {
              const total = data['donutDashboard'].series.reduce(function (prev, series) {
                  return prev + series.value;
              }, 0);
              return total + '%';
          }
      },
      events: {
          draw(data: any): void {
              if (data.type === 'label') {
                  if (data.index === 0) {
                      data.element.attr({
                          dx: data.element.root().width() / 2,
                          dy: data.element.root().height() / 2
                      });
                  } else {
                      data.element.remove();
                  }
              }

          }
      }
  };
  // Donut chart configuration Ends

  //  Bar chart configuration Starts
  BarChart: Chart = {
      type: 'Bar', data: data['DashboardBar'], options: {
          axisX: {
              showGrid: false,
          },
          axisY: {
              showGrid: false,
              showLabel: false,
              offset: 0
          },
          low: 0,
          high: 60, // creative tim: we recommend you to set the high sa the biggest value + something for a better look
      },
      responsiveOptions: [
          ['screen and (max-width: 640px)', {
              seriesBarDistance: 5,
              axisX: {
                  labelInterpolationFnc: function (value) {
                      return value[0];
                  }
              }
          }]
      ],
      events: {
          created(data: any): void {
              const defs = data.svg.elem('defs');
              defs.elem('linearGradient', {
                  id: 'gradient4',
                  x1: 0,
                  y1: 1,
                  x2: 0,
                  y2: 0
              }).elem('stop', {
                  offset: 0,
                  'stop-color': 'rgba(238, 9, 121,1)'
              }).parent().elem('stop', {
                  offset: 1,
                  'stop-color': 'rgba(255, 106, 0, 1)'
              });
              defs.elem('linearGradient', {
                  id: 'gradient5',
                  x1: 0,
                  y1: 1,
                  x2: 0,
                  y2: 0
              }).elem('stop', {
                  offset: 0,
                  'stop-color': 'rgba(0, 75, 145,1)'
              }).parent().elem('stop', {
                  offset: 1,
                  'stop-color': 'rgba(120, 204, 55, 1)'
              });

              defs.elem('linearGradient', {
                  id: 'gradient6',
                  x1: 0,
                  y1: 1,
                  x2: 0,
                  y2: 0
              }).elem('stop', {
                  offset: 0,
                  'stop-color': 'rgba(132, 60, 247,1)'
              }).parent().elem('stop', {
                  offset: 1,
                  'stop-color': 'rgba(56, 184, 242, 1)'
              });
              defs.elem('linearGradient', {
                  id: 'gradient7',
                  x1: 0,
                  y1: 1,
                  x2: 0,
                  y2: 0
              }).elem('stop', {
                  offset: 0,
                  'stop-color': 'rgba(155, 60, 183,1)'
              }).parent().elem('stop', {
                  offset: 1,
                  'stop-color': 'rgba(255, 57, 111, 1)'
              });

          },
          draw(data: any): void {
              let barHorizontalCenter, barVerticalCenter, label, value;
              if (data.type === 'bar') {

                  data.element.attr({
                      y1: 195,
                      x1: data.x1 + 0.001
                  });

              }
          }
      },

  };
  // Bar chart configuration Ends

  constructor(private resourcesService: ResourceService, private auth: AuthService,
    private router: Router, private modalService: NgbModal ) {
  }

  ngOnInit() {

    // this.rerender();
    this.resourcesService.getResourcesUtilization();

    setTimeout(() => {
      this.resourcesService.getResourcesAndRates();
      this.resourcesService.getRateCards();

    }, 250);

    this.getResources();
    this.getRatecards();
  }

  percentageUtilization(u, a) {

    let per$ = (u / a) * 100;
    if (per$ === undefined || Number.isNaN(per$)) {
     per$ = 0;
    }
    return per$;
  }

  percentageAvailable(c , a) {

    // calculation based on monthly reporting (8 hour days, 5 day week and 52 weeks year)

    if (this.showin === 'days') {
      c = c;
    }
    if (this.showin === 'hours') {
      c = c * 8;
    }
    if (this.showin === 'FTE') {
      c = c / 21.6667;
    }
    let per = (a / c) * 100;
    if (per === undefined || Number.isNaN(per)) {
      per = 0;
    }
    return per;
  }

  getResources(): void {
    this.resourcesService.resourcesandrates.subscribe(resources => {

      if (resources.length > 0) {

        this.resources = resources;
        this.resources$.next(resources);
        console.log(this.resources$);
        console.log(this.resources);
        this.resourceCount = formatNumber(this.resources.length);
      }
      return;
    });
    this.resourcesService.utils.subscribe(ut => {

      if (ut.length > 0) {

        this.ut = ut;
        console.log(this.ut);
      }
      return;
    });
  }

  getRatecards(): void {
    this.resourcesService.rateCards
    .subscribe(
        rates => {this.ratecards = rates; console.log(this.ratecards); },
        (error: any) => this.errorMessage = <any>error
    );
  }

  calculateCurrentPeriodUtilization(r: Resource) {
    const id = r.resourceId;
    const currentYear = this.auth.reportingYear;
    const currentperiod = this.auth.reportingPeriod;

    if (this.ut.some(function(x) {return (Number(currentYear) === x.year && x.resourceId === id); })) {
      // const yu = this.resourcesService.utilitiesByResourceIdOneyear(id, Number(currentYear));
      const yu = this.ut.filter(x => x.year === Number(currentYear) && x.resourceId === id)[0];


      // console.log(yu);

      if (currentperiod === 'January') {
        return (-yu.janAvailabilityAfterHolidaysInDays + yu.janResourceUtilizationInDays);
      }
      if (currentperiod === 'February') {
        return (-yu.febAvailabilityAfterHolidaysInDays + yu.febResourceUtilizationInDays);

      }
      if (currentperiod === 'March') {
        return (-yu.marAvailabilityAfterHolidaysInDays + yu.marResourceUtilizationInDays);

      }
      if (currentperiod === 'April') {
        return (-yu.aprAvailabilityAfterHolidaysInDays + yu.aprResourceUtilizationInDays);

      }
      if (currentperiod === 'May') {
        return (-yu.mayAvailabilityAfterHolidaysInDays + yu.mayResourceUtilizationInDays);

      }
      if (currentperiod === 'June') {
        return (-yu.junAvailabilityAfterHolidaysInDays + yu.junResourceUtilizationInDays);

      }
      if (currentperiod === 'July') {
        return (-yu.julAvailabilityAfterHolidaysInDays + yu.julResourceUtilizationInDays);

      }
      if (currentperiod === 'August') {
        return (-yu.augAvailabilityAfterHolidaysInDays + yu.augResourceUtilizationInDays);

      }
      if (currentperiod === 'Septemebr') {
        return (-yu.sepAvailabilityAfterHolidaysInDays + yu.sepResourceUtilizationInDays);

      }
      if (currentperiod === 'October') {
        return (-yu.octAvailabilityAfterHolidaysInDays + yu.octResourceUtilizationInDays);

      }
      if (currentperiod === 'November') {
        return (-yu.novAvailabilityAfterHolidaysInDays + yu.novResourceUtilizationInDays);

      }
      if (currentperiod === 'December') {
        return (-yu.decAvailabilityAfterHolidaysInDays + yu.decResourceUtilizationInDays);

      }
      return 0;
    }
    return 0;

  }

  overUnderUtilization(num) {
    if (num === 0) {
      return 'text-success';
    } else {
      return 'text-danger';
    }
  }

  overUnderUtilizationPercent(num) {
    if (num === 0 || num === 1) {
      return 'badge-success';
    } else {
      return 'badge-danger';
    }
  }

  returnUtils (r: Resource) {

    const currentYear = this.auth.reportingYear;
    const currentperiod = this.auth.reportingPeriod;

    let ut: ResourceUtilization = new ResourceUtilization();
    ut = r.resourceutilizationSummaries.find(x => x.year === Number(currentYear))[0];

    return ut;

  }
  calculateCurrentPeriodDemand(r: Resource) {

    const id = r.resourceId;
    const currentYear = this.auth.reportingYear;
    const currentperiod = this.auth.reportingPeriod;

    if (this.ut.some(function(x) {return (Number(currentYear) === x.year && x.resourceId === id); })) {
      const yu = this.ut.filter(x => x.year === Number(currentYear) && x.resourceId === id)[0];


      if (currentperiod === 'January') {
        return (yu.janResourceUtilizationInDays);
      }
      if (currentperiod === 'February') {
        return (yu.febResourceUtilizationInDays);

      }
      if (currentperiod === 'March') {
        return (yu.marResourceUtilizationInDays);

      }
      if (currentperiod === 'April') {
        return (yu.aprResourceUtilizationInDays);

      }
      if (currentperiod === 'May') {
        return (yu.mayResourceUtilizationInDays);

      }
      if (currentperiod === 'June') {
        return (yu.junResourceUtilizationInDays);

      }
      if (currentperiod === 'July') {
        return (yu.julResourceUtilizationInDays);

      }
      if (currentperiod === 'August') {
        return (yu.augResourceUtilizationInDays);

      }
      if (currentperiod === 'Septemebr') {
        return (yu.sepResourceUtilizationInDays);

      }
      if (currentperiod === 'October') {
        return (yu.octResourceUtilizationInDays);

      }
      if (currentperiod === 'November') {
        return (yu.novResourceUtilizationInDays);

      }
      if (currentperiod === 'December') {
        return (yu.decResourceUtilizationInDays);

      }
        return 0;
    }
      return 0;

  }
  calculateCurrentPeriodFTE(r: Resource) {
    const id = r.resourceId;
    const currentYear = this.auth.reportingYear;
    const currentperiod = this.auth.reportingPeriod;

    if (this.ut.some(function(x) {return (Number(currentYear) === x.year && x.resourceId === id); })) {
      const yu = this.ut.filter(x => x.year === Number(currentYear) && x.resourceId === id)[0];

      // console.log(yu);

      if (currentperiod === 'January') {
        return (yu.janAvailabilityBeforeHolidaysInDays);
      }
      if (currentperiod === 'February') {
        return (yu.febAvailabilityBeforeHolidaysInDays);

      }
      if (currentperiod === 'March') {
        return (yu.marAvailabilityBeforeHolidaysInDays);

      }
      if (currentperiod === 'April') {
        return (yu.aprAvailabilityBeforeHolidaysInDays);

      }
      if (currentperiod === 'May') {
        return (yu.mayAvailabilityBeforeHolidaysInDays);

      }
      if (currentperiod === 'June') {
        return (yu.junAvailabilityBeforeHolidaysInDays);

      }
      if (currentperiod === 'July') {
        return (yu.julAvailabilityBeforeHolidaysInDays);

      }
      if (currentperiod === 'August') {
        return (yu.augAvailabilityBeforeHolidaysInDays);

      }
      if (currentperiod === 'Septemebr') {
        return (yu.sepAvailabilityBeforeHolidaysInDays);

      }
      if (currentperiod === 'October') {
        return (yu.octAvailabilityBeforeHolidaysInDays);

      }
      if (currentperiod === 'November') {
        return (yu.novAvailabilityBeforeHolidaysInDays);

      }
      if (currentperiod === 'December') {
        return (yu.decAvailabilityBeforeHolidaysInDays);

      }
      return 0;
    }
    return 0;
  }
  calculateCurrentPeriodAbsence(r: Resource) {
    const id = r.resourceId;
    const currentYear = this.auth.reportingYear;
    const currentperiod = this.auth.reportingPeriod;

    if (this.ut.some(function(x) {return (Number(currentYear) === x.year && x.resourceId === id); })) {
      const yu = this.ut.filter(x => x.year === Number(currentYear) && x.resourceId === id)[0];

      console.log(yu);
      if (currentperiod === 'January') {
        return (yu.janTotalHolidays);
      }
      if (currentperiod === 'February') {
        return (yu.febTotalHolidays);

      }
      if (currentperiod === 'March') {
        return (yu.marTotalHolidays);

      }
      if (currentperiod === 'April') {
        return (yu.aprTotalHolidays);

      }
      if (currentperiod === 'May') {
        return (yu.mayTotalHolidays);

      }
      if (currentperiod === 'June') {
        return (yu.junTotalHolidays);

      }
      if (currentperiod === 'July') {
        return (yu.julTotalHolidays);

      }
      if (currentperiod === 'August') {
        return (yu.augTotalHolidays);

      }
      if (currentperiod === 'Septemebr') {
        return (yu.sepTotalHolidays);

      }
      if (currentperiod === 'October') {
        return (yu.octTotalHolidays);

      }
      if (currentperiod === 'November') {
        return (yu.novTotalHolidays);

      }
      if (currentperiod === 'December') {
        return (yu.decTotalHolidays);

      }
        return 0;
      }

      return 0;
  }


  // filter(search) {
  //   this.resources$.next(this.resources.filter(_ => Object.keys(_).some(k => _[k].toLowerCase().includes(search.toLowerCase()))));
  // }
  empBadge(emp) {

    if (emp === 'Permanent_Staff') {
      return 'badge-primary'
    }
    if (emp === 'Temporary_Staff') {
      return 'badge-warning'
    }
    if (emp === 'Contractor') {
      return 'badge-danger'
    }
    if (emp === 'Managed_Service') {
      return 'badge-info'
    }
    return;
  }

  changeShowin(show) {
    this.showin = show;
  }
  // filter(search) {
  //   this.resources$.next(this.resources.filter(_ => JSON.stringify(_).toLowerCase().indexOf(search.toLowerCase()) !== -1));
  // }

  filter(search) {
    this.resources$.next(this.resources.filter(_ => _.displayName.toLowerCase().includes(search.toLowerCase()) ))}


  newResource() {
    const modalRef = this.modalService.open(EditResourceComponent, {size: 'lg', windowClass: 'modal-xl'});
    modalRef.componentInstance.id = '';
    modalRef.componentInstance.header = 'Create new resource';
    modalRef.componentInstance.resources = this.resources;
    modalRef.componentInstance.ratecards = this.ratecards;
  }
  gotoResource(res: IResourceList) {

    // this.router.navigate(['/resources/resource']);
    this.router.navigate(['/resources/resource', res.resourceId]);
  }
  editResource(res: IResourceList) {
    const modalRef = this.modalService.open(EditResourceComponent, {size: 'lg', windowClass: 'modal-xl'});
    modalRef.componentInstance.id = res.resourceId;
    modalRef.componentInstance.header = `Edit resource:`;
    modalRef.componentInstance.resources = this.resources;
    modalRef.componentInstance.ratecards = this.ratecards;
  }
  deleteResource(res: IResourceList) {
    const modalRef = this.modalService.open(DeleteResourceComponent, {size: 'lg', windowClass: 'modal-xl'});
    modalRef.componentInstance.id = res.resourceId;
  }

  // Open default modal
  open(content) {
    this.modalService.open(content).result.then((result) => {
        this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
        this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
}

// This function is used in open
private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
        return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
        return 'by clicking on a backdrop';
    } else {
        return `with: ${reason}`;
    }
}

}

function formatNumber (num) {
  return num.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,');
}


