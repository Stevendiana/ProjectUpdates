import { Component, OnInit, ViewChild } from '@angular/core';
import { ChartEvent, ChartType } from 'ng-chartist';
import * as Chartist from 'chartist';
import { Subject } from 'rxjs';
import { IResourceList } from '../resource';
import { DataTableDirective } from 'angular-datatables';
import { ResourceService } from '../resources.service';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { NewResourceComponent } from '../resource/new-resource.component';

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
  selector: 'app-resources-dashboard',
  templateUrl: './resources-dashboard.component.html',
  styleUrls: ['./resources-dashboard.component.scss']
})
export class ResourcesDashboardComponent implements OnInit {

  resources$: IResourceList[] = [];
  resourceCount: number;
  closeResult: string;

  @ViewChild(DataTableDirective) dtElement: DataTableDirective;


  @ViewChild('exampleTableTools') table;
  dtOptions: any = {};
  // dtOptions: DataTables.Settings = {};
  example: any;
  dtTrigger: Subject<any> = new Subject();

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

  constructor(private resourcesService: ResourceService, private modalService: NgbModal ) {
  }

  ngOnInit() {


    this.dtOptions = {

      pagingType: 'full_numbers',
      pageLength: 100,
      processing: true,
      // data: this.resources$,
      // 'bDestroy': true,
      'paging':   true,
      'ordering': true,
      'info':     true,
      'columnDefs':
      [ {
          'targets': [3],
          'visible': true,
          'searchable': true
        },

        {
        'targets': [4],
        'visible': true
        }
          // ,{ 'bSortable': true, 'bSort': false, 'aTargets': [ '_all' ] }
      ],

      // responsive: true,
      searching: true,
      select: true,
      order: [0, 'desc'],
      dom: `<
             <"row"
               <"col-lg-3 col-md-12"l>
               <"col-lg-6 col-md-12 button-wrapper btn-sm danger"B>
               <"col-lg-3 col-md-12"f>><hr>
             <"row" <"col"t>>
             <"row"
               <"col"i>
               <"col btn-sm"p>>
             >`,

      buttons: [
      'copy', 'csv', 'excel', 'pdf', 'print',
        {
          text: 'GroupBy',
          key: '1',
          action: function (e, dt, node, config) {
            alert('Button activated');
          }
        },
        {
          text: 'Some button',
          key: '1',
          action: function (e, dt, node, config) {
            alert('Button activated');
          }
        },
        {
          text: 'Some button',
          key: '1',
          action: function (e, dt, node, config) {
            alert('Button activated');
          }
        },

      ],
      'bLengthChange': true,
      'Filter': true,
      // retrieve: true,
      language: {
        search: '_INPUT_',
       searchPlaceholder: 'Search records',
      },
      'Info': true,
      // fixedHeader: {
      //   header: true,
      //   bottom: true,
      //   // footer: false,
      //   zTop: 1000
      //   // headerOffset: 400

      // },

    };

    this.resourcesService.getResourcesAndRates();
    this.getResources();
    this.rerender();


    this.example = $(this.table.nativeElement);
    this.example.DataTable(this.dtOptions);

    setTimeout(() => {
    }, 250);

  }

  getResources(): void {
    this.resourcesService.resourcesandrates.subscribe(resources => {

      setTimeout(() => {
        this.resources$ = resources;
        // this.dtTrigger.next();
        console.log(this.resources$);
        this.resourceCount = formatNumber(this.resources$.length);
        }, 250);

    });
  }

  // tslint:disable-next-line:use-life-cycle-interface
  ngOnDestroy(): void {
    this.dtTrigger.unsubscribe();
  }

  // tslint:disable-next-line:use-life-cycle-interface
  ngAfterViewInit(): void {this.dtTrigger.next(); }

  rerender(): void {
    this.example.dtInstance.then((dtInstance: DataTables.Api) => {

      // Destroy the table first
      dtInstance.destroy();
      // Call the dtTrigger to rerender again
      this.dtTrigger.next();
    });
  }

  openContent() {
    const modalRef = this.modalService.open(NewResourceComponent, {size: 'lg', windowClass: 'modal-xl'});
    modalRef.componentInstance.name = 'World';
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


