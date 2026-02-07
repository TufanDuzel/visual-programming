## 📘 Notes from Class

### 🧩 What is Debugging?
Debugging means **running the program step by step** to see what’s really happening inside.  
It helps you find logic errors, see variable values, and understand the order of execution.  

- **Breakpoint (F9):** Stop the code at a specific line.  
- **F5:** Start debugging mode.  
- **F10 / F11:** Move step-by-step through your code.  
- **Watch / Locals:** See live variable values.  

Even a simple line like `Console.WriteLine("Debug: value = " + value);` is a form of “manual debugging”.

---

### ⚡ What are Event Handlers and Sender?
- **Event:** Something happens (for example, a button is clicked).  
- **Handler:** The function that runs when the event happens.  
- **Sender:** The control that triggered the event — it tells you *which* button or object caused it.  

Example idea:  
If two buttons use the same handler, `sender` lets you check *which one* was clicked.

---

### 🧱 File Roles in a WinForms Project

| File | Purpose |
|------|----------|
| **Program.cs** | Entry point. Starts the application and opens the first form (`Application.Run(new Form1());`). |
| **Form1.cs** | Your logic and event handlers — what happens when you click a button, type text, etc. |
| **Form1.Designer.cs** | Auto-generated setup code — creates buttons, labels, sets positions and connects events. You normally don’t edit this directly. |
| **Form1 (Design View)** | The visual interface editor. Drag & drop controls, set properties, and attach events (⚡ tab). It updates the Designer file automatically. |

---

### 🧠 About .NET
.NET is the **framework** that runs and manages your C# code.  
It includes:
- **CLR (Common Language Runtime):** Runs the program and manages memory.  
- **BCL (Base Class Library):** Common tools (like `List`, `File`, `Console`, `Form`, etc).  
- **Languages:** C#, VB.NET, F#, etc.  

Your WinForms app is a **.NET project** — it’s both a **program** and a **user interface (GUI)** built on top of the .NET framework.

---

### 💡 Summary
- Debugging = Watching your program in slow motion.  
- Handler = The code that reacts to an event.  
- Sender = Who triggered the event.  
- Designer = Layout setup; Form1.cs = your logic.  
- .NET = The engine running it all.  