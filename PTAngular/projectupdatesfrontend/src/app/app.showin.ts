import {Pipe, PipeTransform} from '@angular/core';
@Pipe ({
   name : 'showin'
})
export class ShowinPipe implements PipeTransform {
   transform(val: number, si: string ): number {

    if (si === 'days') {
      const res = val;
      return res;

    }
    if (si === 'hours') {
      const res = val * 8;
      return res;

    }
    if (si === 'FTE') {
      const res = val / 21.6667;
      return res;
    }
    return;
  }
}
