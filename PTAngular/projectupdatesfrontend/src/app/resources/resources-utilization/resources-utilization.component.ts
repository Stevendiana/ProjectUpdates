import { Component, OnInit, ViewChild } from '@angular/core';
import { ChartEvent, ChartType } from 'ng-chartist';
import * as Chartist from 'chartist';
import { Subject } from 'rxjs';

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
  selector: 'app-resources-utilization',
  templateUrl: './resources-utilization.component.html',
  styleUrls: ['./resources-utilization.component.scss']
})
export class ResourcesUtilizationComponent implements OnInit {

  currentyear: number;
  year1: number;
  year2: number;
  year3: number;
  year4: number;
  year5: number;
  year6: number;
  year7: number;
  year8: number;
  year9: number;
  year10: number;

  previous = false;
  current = false;
  future = false;



  // constructor() { }

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

            var defs = data.svg.elem('defs');
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

            var defs = data.svg.elem('defs');
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
            var defs = data.svg.elem('defs');
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

            var circleRadius = 6;
            if (data.type === 'point') {
                var circle = new Chartist.Svg('circle', {
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
            var circleRadius = 6;
            if (data.type === 'point') {
                var circle = new Chartist.Svg('circle', {
                    cx: data.x,
                    cy: data.y,
                    r: circleRadius,
                    class: 'ct-point-circle'
                });
                data.element.replace(circle);
            }
            else if (data.type === 'label') {
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
              var defs = data.svg.elem('defs');
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
              var defs = data.svg.elem('defs');
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

              }
              else if (data.type === 'label') {
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
              var defs = data.svg.elem('defs');
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
              var circleRadius = 4;
              if (data.type === 'point') {

                  var circle = new Chartist.Svg('circle', {
                      cx: data.x,
                      cy: data.y,
                      r: circleRadius,
                      class: 'ct-point-circle'
                  });
                  data.element.replace(circle);
              }
              else if (data.type === 'label') {
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
              var circleRadius = 4;
              if (data.type === 'point') {
                  var circle = new Chartist.Svg('circle', {
                      cx: data.x,
                      cy: data.y,
                      r: circleRadius,
                      class: 'ct-point-circle'
                  });

                  data.element.replace(circle);
              }
              else if (data.type === 'label') {
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
              var total = data['donutDashboard'].series.reduce(function (prev, series) {
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
              var defs = data.svg.elem('defs');
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
              var barHorizontalCenter, barVerticalCenter, label, value;
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


  ngOnInit() {

    this.currentyear = 2005;
    this.year1 = this.currentyear;
    this.year2 = this.currentyear + 1;
    this.year3 = this.currentyear + 2;
    this.year4 = this.currentyear + 3;
    this.year5 = this.currentyear + 4;
    this.year6 = this.currentyear + 5;
    this.year7 = this.currentyear + 6;
    this.year8 = this.currentyear + 7;
    this.year9 = this.currentyear + 8;
    this.year10 = this.currentyear + 9;
  }

}