import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'sensor',
    templateUrl: './sensor.component.html',
})

export class SensorComponent {
    public sensorData: number[];

    constructor(http: Http) {
        http.get('/api/Sensor').subscribe(result => {
            this.sensorData = result.json() as number[];
        });
    }
}
