
## Dependencies

- [JDK 1.8.0_121](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)
- [Unity 5.5.0f3](https://unity3d.com/get-unity/download/archive)
- [Android SDK 24](https://developer.android.com/studio/index.html)
- [GoogleVR Unity SDK 1.0.3](https://github.com/googlevr/gvr-unity-sdk/releases/tag/v1.0.3)
    + 1.10.0 doesn't compile and crashes on startup

[Source](https://www.youtube.com/watch?v=B_hS4DdH1xg)

## Troubleshooting

- Build Settings > Player Settings
    + Minimum API Level: `Android 6.0 'Marshmallow' (API level 23)`
    + Virtual Reality Supported: `false`
- Preferences
    + Check that the right JDK and Android SDK are specified
