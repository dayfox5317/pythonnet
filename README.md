This is just simple build fix for c# developer without much knowledge of python
(based on [amos's fork of python.net](https://github.com/amos402/pythonnet) which is believed memory leak issues have been resolved)

# How To Get Python.Runtime.dll(Either DEBUG/RELEASE)

- Open pythonnet.sln in visual studio 2015
- Choose  "ReleaseWin"/"DebugWin" (If you use Python2.7), or "ReleaseWinPy3"/"DebugWinPy3"(for Python3.x) with AnyCpu Platform
- When built, copy ./src/runtime/bin/Python.Runtime.dll to your own project.

Please also refer to original [Python.Net repo](https://github.com/pythonnet/pythonnet)


