import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter',
})
export class FilterPipe implements PipeTransform {
  transform(items: any[], searchText: any): any[] {
    if (!items) {
      return [];
    }
    if (!searchText) {
      return items;
    }
    searchText = searchText;

    const filteredData = items
      .filter((obj) => {
        const searchString = Object.values(obj).join(' ').toLowerCase();
        return searchString.includes(searchText.toLowerCase());
      })
      .map((obj) => ({ name: obj.name, age: obj.age, hobbies: obj.hobbies }));

    return filteredData;
  }
}
