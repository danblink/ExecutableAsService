# ExecutableAsService
A .NET application that allows you to run a program as a Window service.
There are already programs that do this out there, but mine is entirely GUI based so it should be easier to use.
[NSSM] for example does have GUI elements but you still have to use command line arguments to access them.
[NSSM] also installs itself at the current location so moving it breaks the services, my version self installs to a permenant location.
[NSSM] however has a lot more features than this program, so you should use that instead if you have more advanced requirements.

## Notes

I'm not a great programmer so this is likely to have plenty of flaws. Use it at your own risk.
If you do encounter issues, I would appreciate it if you reported them so I could fix them, or contributed yourself.
Feedback is always welcome and feel free to look at/copy code for your own use. :)

### References

Special thanks to [David Scott Turner and his blog post on how to create self-installing Windows Services](http://thedavejay.blogspot.co.uk/2012/04/self-installing-c-windows-service-safe.html?m=1) .

This was inspired by [NSSM so be sure to check it out as well](http://www.nssm.cc/).

[NSSM]: http://www.nssm.cc/
