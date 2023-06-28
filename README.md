# AtPulso
App for output your HeartRate to stream with OBS or any another application with Browser-Source.

It can show:
- HeartRate
- Time-scalled Animation (it will be beats 1.5 times/second if your heartrate is 90)
- Chart

1. Download publish.zip from [Releases](https://github.com/alextrof94/AtPulso/releases)
2. Unzip and Install
3. Pair BT device via Windows-menu (once).
4. "Connect" device in app.
5. If connected and checkbox "Autostart server when connected" is setted - copy Server-Address to OBS. Otherwise - first "Start" server.


UI settings updates on the fly by reload page in browser (or widget in OBS).

![Preview2](https://github.com/alextrof94/AtPulso/blob/main/images/screenshot.jpg)

![Settings](https://github.com/alextrof94/AtPulso/blob/main/images/main.jpg)


## Animation
For animation you need to select webm video with length of 1 sec with 1 "beat"

You can download animations from [animations link](https://github.com/alextrof94/AtPulso/tree/main/animations) or create your own and select it.

![Preview1](https://github.com/alextrof94/AtPulso/blob/main/images/preview.gif)

You also can add CSS filter for animation to change color of animation. For example change color from black to red:
```
filter: invert(10%) sepia(94%) saturate(7448%) hue-rotate(358deg) brightness(100%) contrast(107%);
```
[Page with generating filters](https://codepen.io/sosuke/pen/Pjoqqp)



## Compatibility
### Don't working with:
 - Mi Bands 4+ & Amazfits (they are protected from connecting to third-party applications)

### Working with:
 - Magene H303 (chest sensor)
 - CooSpo H808S (chest sensor)
