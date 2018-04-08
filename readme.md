# Marten UnitOfWork Example for System.ObjectDisposedException: Cannot access a disposed object

Run below command to see failure result.

``` bash
dotnet test --filter DisplayName~FailingTests
```

Run to see proper usage of unit of work.

``` bash
dotnet test --filter DisplayName~SucceedTests
```