import {Pipe, PipeTransform} from '@angular/core';
@Pipe ({
   name : 'fl'
})
export class FlPipe implements PipeTransform {
   transform(val: string): string {
    const res = val.charAt(0)
    return res;
  }
}
