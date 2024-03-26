import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface LiveForecast {
  location: string;
  date: Date;
  wind: string;
  airquality: string;
  celsius: string;
  fahrenheit: string;
  summary: string;
}

@Component({
  selector: 'app-forecast',
  templateUrl: './forecast.component.html',
  styleUrls: ['./forecast.component.css']
})
export class ForecastComponent implements OnInit {
  public forecast: LiveForecast = {
    location: '',
    date: new Date(),
    wind: '',
    airquality: '',
    celsius: '',
    fahrenheit: '',
    summary: ''
  };

  constructor(private http: HttpClient) { }
    ngOnInit(): void {
        throw new Error('Method not implemented.');
    }



  saveLiveWeather() {
    this.http.post<LiveForecast>('/api/liveforecast', this.forecast).subscribe(
      (result) => {
        console.log('User info saved successfully:', result);
      },
      (error) => {
        console.error('Error saving user info:', error);
      }
    );
  }


  title = 'liveforecast.client';
}
