# visualstudio_run_as_admin

<p align="center">
  <img src="visualstudio_run_as_admin.png" width="180">
</p>

Launch Visual Studio as Administrator directly from `.sln` files.

---

# Usage

## Windows 11

Right-click any `.sln` file:

```text
Open with
→ Choose another app
→ Look for another app on this PC
```

Select:

```text
visualstudio_run_as_admin.exe
```

Enable:

```text
Always use this app to open .sln files
```

Then click:

```text
OK
```

Done.

From now on, double-clicking `.sln` files will automatically launch Visual Studio as Administrator.

---

# Notes

- Windows UAC confirmation will appear before launch
- Works with Visual Studio Solution files (`.sln`)
- Currently tested with Visual Studio 2022
- Other Visual Studio versions may require additional testing

---

# License

This project is free to use for personal and commercial purposes.

No attribution required.

---

# Author

by SNIDzTOP