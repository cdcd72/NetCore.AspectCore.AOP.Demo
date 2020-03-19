# NetCore.AspectCore.AOP.Demo
> 這個專案專注於利用 AspectCore 實作 AOP 機制。  
> This project focus on the use of **AspectCore** to implement AOP mechanism.  

練習套用 AspectCore 實作 AOP 機制於 .NET Core 3.1 上。  
To practice how AOP mechanism with AspectCore implement on .NET Core 3.1.  

## 運行專案
> 假如你想要直接測試應用程式，可以使用 [Postman](https://www.getpostman.com/) 或其他一些用於模擬 Client-side 行為的應用程式。  

If you want to interactively test the application, you can use [Postman](https://www.getpostman.com/) or any other Http client.

> 透過 Visual Studio 2019 或者利用 `dotnet run` 指令先把專案跑起來。
1. Run the project from Visual Studio 2019 or by typing `dotnet run` in a command window  

> 透過 _Postman_ 製作一個如下所示之 GET 要求  
2. Launch _Postman_ and make a GET request as follows:

```
    GET https://localhost:5001/customexecutexxxx HTTP/1.1
    cache-control: no-cache
    Accept: */*
    Host: localhost:5001
    accept-encoding: gzip, deflate, br
    Connection: keep-alive
```

> 便會得到以下回應：  

returns the following response:

```
CustomService.ExecuteXXXX method executed via serviceaop.
```

> 製作另一個如下所示之 GET 要求   
3. Then make another a GET request like the following:

```
    GET https://localhost:5001/otherexecutexxxx HTTP/1.1
    cache-control: no-cache
    Accept: */*
    Host: localhost:5001
    accept-encoding: gzip, deflate, br
    Connection: keep-alive
```

> 便會得到以下回應：  

returns the following response:

```
OtherService.ExecuteXXXX method executed.
```

> 總結來說，**第一個**被執行的方法**會**被 ServiceAop 抓到，而**第二個**被執行的方法則**不會**被 ServiceAop 抓到。  
4. To sum up, first one executed method can catched by serviceaop, second one executed method can't catched by serviceaop.  

## 最後版本
1.0.0.0 (March 19, 2020)

## 記錄
* 1.0.0.0
  * Initial Commit (初次上版)
  
## 參考 github
[AspectCore-Framework](https://github.com/dotnetcore/AspectCore-Framework) by dotnetcore  

## 參考文章
* Chinese
  * [ASP.NET Core 3.0 使用AspectCore-Framework实现AOP](https://www.cnblogs.com/king-23100/p/11821020.html)  
  * [Asp.Net Core轻量级Aop解决方案：AspectCore](https://www.cnblogs.com/liuhaoyang/p/aspectcore-introduction-1.html)  
  * [.NET Core中使用开源的AOP框架 AspectCore](http://www.vnfan.com/buffett/d/f51118e10b91283.html)  
