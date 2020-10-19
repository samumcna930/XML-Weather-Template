using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, conditionNumber, location, tempHigh, tempLow, 
            windSpeed, windDirection, humidity, visibility, feelsLikeTemp, sunRise, sunSet;

        public Day()
        {
            feelsLikeTemp = date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = humidity = visibility = sunRise = sunSet = "";
        }
    }
}
