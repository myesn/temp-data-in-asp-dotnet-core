# 介绍

想象一个场景，比如注册后跳转到其它页面：
1. 在注册页面：注册成功后，跳转到登录页面
2. 在登录页面：仅提示一次注册成功

一般页面跳转后给出上一个页面的操作提示是一件麻烦的事情，但使用 [TempData](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/app-state#tempdata) 使得事情变得简单。

`TempData` 中数据的生命周期是下次请求内，在请求结束就会被删除，类似 `Scoped`。

也就是说在第一次请求里面为 TempData 属性赋值，下一次请求访问它的时候，能获取值，但在请求结束后，值就会被删除，由于 TempData 是一个 Dictionary，所以删除的是键值对。

它的使用方式是：首先给属性添加 `[TempData]` 标记，代表这是一个临时数据，直到在另一个请求中读取数据，读取之后就被删除了，不过它有多种使用方式：
1. 访问 TempData 值后**在请求结束后不删除**，通过调用 [Keep](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.viewfeatures.itempdatadictionary.keep) 或 [Peek](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.viewfeatures.itempdatadictionary.peek) 来保持数据不被删除。
2. 访问 TempData 值后在**请求结束后删除**，直接使用字典访问的方式 `TempData["Message"]`

具体参考官方文档：https://learn.microsoft.com/en-us/aspnet/core/fundamentals/app-state#tempdata

完整代码参考：https://github.com/myesn/temp-data-in-asp-dotnet-core
