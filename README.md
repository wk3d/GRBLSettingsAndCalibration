# GRBLSettingsAndCalibration

This is a tool for manipulating GRBL settings made for my own use but I expect it will come in handy for anyone building a cnc machine with GRBL. I have used this on an Arduino with a CNC shield and it does the job. It is inteded to allow easy configuration and calibration of the axes steps/mm (or inch). I use mm so that's what the text shows.

This software is realeased under BSD 3.0 license.

~~Changes to the software will be updated here. The only future change planned is a simple squaring functionality for squaring the x and y axes.~~

Squaring logic added. It depends on measuring diagonal movement and comparing with the expected length. Adjustment is done based on whether the movement was higher or lower than exptected.
