# 🚀 Overkill

**_A .NET playground for design pattern maximalists and abstraction absolutists._**

Welcome to **Overkill** – the ultimate destination for doing way too much™ with C#.

Why write a simple `for` loop when you can encapsulate it into an `ILoop` interface with multiple pluggable looper strategies like `ForLooper`, `WhileLooper`, and `RecursiveLooper`?

Yes, it's **ridiculous**.  
Yes, it's **unnecessary**.  
Yes, it's **Overkill**.

> _"Just because you can, doesn't mean you should. But we're doing it anyway."_  
> — A wise fool

---

## 💡 What is this?

**Overkill** is a .NET Core repository dedicated to pushing the boundaries of what you *should not* do with object-oriented programming.

Here, we try to:
- Wrap primitive types into services.
- Replace basic language constructs with interface-driven architecture.
- Turn every operation into a dependency-injected strategy pattern.
- Abstract the absurd.
- Abuse inheritance for the sake of purity.
- Create adapters for adapters.

---

## 🧪 Examples

```csharp
ILoop loop = new ForLooper(new LoopParameters
{
    Start = 0,
    End = 10,
    Step = 1
});

loop.Execute(new LoopBody(i =>
{
    IConsoleWriter writer = new ConsoleWriter();
    writer.WriteLine($"Iteration {i}");
}));
```

Or:

```csharp
IStructWrapper<int> myInt = new IntWrapper(42);
IMathOperation add = new Addition();
var result = add.Execute(myInt, new IntWrapper(10));
```

_Yes, we **wrap** ints. You got a problem with that?_

---

## 🎯 Goals

- Abuse the SOLID principles until they collapse under their own weight.
- Make even the simplest "Hello, World" feel like configuring a Kubernetes cluster.
- Encourage the community to make contributions that will confuse and horrify future maintainers.

---

## 🤝 Contributing

Pull Requests are **not only welcome**, they’re **celebrated** – especially the most unnecessary ones.

Some inspiration for your contributions:
- `IIfElse` interface with `ConditionalBranchExecutor`
- `ISwitchCase` with a full visitor pattern implementation
- `IVariable<T>` with `MutableVariable<T>` and `ImmutableVariable<T>`
- Abstract factories that build other factories that build loops

💀 If it makes someone ask _"why would anyone do this?"_ — you're on the right track.

---

## 📦 Tech Stack

- .NET 9+
- C#
- Your patience

---

## 🚧 Disclaimer

> This repository is **not** meant for production.  
> It is **not** educational.  
> It is a **cautionary tale**.

---

## 🧠 Philosophy

Overkill isn’t just a name.  
It’s a **lifestyle**.  
Let’s make C# scream.

---

**Now accepting Pull Requests that violate all common sense and architectural sanity.**

Happy abstracting! 🎉
