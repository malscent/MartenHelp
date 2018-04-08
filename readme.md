* Marten UnitOfWork Example for System.ObjectDisposedException: Cannot access a disposed object.

Run 
``` bash
dotnet test --filter DisplayName~FailingTests
```
to see failure result.

Run
``` bash
dotnet test --filter DisplayName~SucceedTests
```
To see proper usage of unit of work.