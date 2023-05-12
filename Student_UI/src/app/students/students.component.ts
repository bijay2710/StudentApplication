import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GridDataResult } from '@progress/kendo-angular-grid';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.scss'],
})
export class StudentsComponent implements OnInit {
  public data: any;
  public name: string = "";
  public filterValue: string = '';
public inputData: string = "";
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.GetDataFromAPI();
  }
  public GetDataFromAPI() {
    this.getData().subscribe((result) => {
      this.data = result;
      console.log(this.data);
    });
  }

  public getData(): Observable<any[]> {
    return this.http.post<any[]>(
      'http://localhost:5256/api/student/GetAllStudents', {}
    );
  }
}
