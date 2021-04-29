# What is ResultNet
Result .Net is a simple library to standardize the returns of APIs and methods that may fail.

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/46536bc0b1df42d38f214949099bed02)](https://www.codacy.com/gh/Gava-NET/ResultNet/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=Gava-NET/ResultNet&amp;utm_campaign=Badge_Grade)
![.NET Core](https://github.com/n4gava/ResultNet/workflows/.NET%20Core/badge.svg)
![Release to NuGet](https://github.com/n4gava/ResultNet/workflows/Release%20to%20NuGet/badge.svg)

## How to use it

Result .Net gives `Result` and `Result<T>` classes that can be used for indicate whether a method has been successfully executed. This means that, if a method returns a `Result` or `Result<T>`, it could fail.

```csharp
   public Result DoSomething() {
      var result = new Result();
    
      // Do something...
       
      if ( /*error condition */ )
         result.Add("Error message");
    
      return result;
   }
```

When you need to return a result value, you should use `Ok` method:

```csharp
   public Result<string> DoSomethingAndReturnString() {
      var result = new Result();
    
      // Do something...
       
      /* if everything run correctly return string value */
      result.Ok("Executed");
    
      return result;
   }
```

To check if a `Result` was executed successfully, you can use the if statement.

```csharp
   [HttpPost]
   public IActionResult Post()
   {
      Result result = DoSomething();
      if (!result)
         return BadRequest(result);  
         
      return Ok(result);
   }
```
