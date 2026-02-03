# JERP 2.0 Testing Guide

## Overview

The JERP 2.0 project includes comprehensive testing at multiple levels:
- Unit Tests: Test individual components in isolation
- Integration Tests: Test API endpoints with real database
- (Tests directory structure created but tests not yet implemented)

## Running Tests

### Run All Tests
```bash
cd /path/to/JERP-3.0
dotnet test
```

### Run Specific Test Project
```bash
# Unit tests
dotnet test tests/JERP.Application.Tests

# Integration tests
dotnet test tests/JERP.Api.Tests
```

### Run with Coverage
```bash
dotnet test --collect:"XPlat Code Coverage"
```

## Test Structure

```
tests/
├── JERP.Application.Tests/          # Unit tests
│   ├── Services/
│   │   ├── PayrollServiceTests.cs
│   │   ├── TaxCalculationServiceTests.cs
│   │   └── EmployeeServiceTests.cs
│   └── Validators/
│       └── EmployeeValidatorTests.cs
│
└── JERP.Api.Tests/                  # Integration tests
    ├── Controllers/
    │   ├── AuthControllerTests.cs
    │   ├── EmployeesControllerTests.cs
    │   └── PayrollControllerTests.cs
    └── Infrastructure/
        └── WebApplicationFactory.cs
```

## Writing Tests

### Unit Test Example

```csharp
public class PayrollServiceTests
{
    private readonly Mock<JerpDbContext> _mockContext;
    private readonly PayrollService _service;

    public PayrollServiceTests()
    {
        _mockContext = new Mock<JerpDbContext>();
        _service = new PayrollService(_mockContext.Object);
    }

    [Fact]
    public async Task CalculateGrossPay_StandardHours_ReturnsCorrectAmount()
    {
        // Arrange
        var hours = 40m;
        var rate = 15.00m;
        
        // Act
        var result = _service.CalculateGrossPay(hours, rate);
        
        // Assert
        result.Should().Be(600.00m);
    }
}
```

### Integration Test Example

```csharp
public class EmployeesControllerTests : IClassFixture<CustomWebApplicationFactory>
{
    private readonly HttpClient _client;

    public EmployeesControllerTests(CustomWebApplicationFactory factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetEmployees_ReturnsOkResult()
    {
        // Arrange
        var token = await GetAuthTokenAsync();
        _client.DefaultRequestHeaders.Authorization = 
            new AuthenticationHeaderValue("Bearer", token);

        // Act
        var response = await _client.GetAsync("/api/v1/employees");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}
```

## Test Database

Integration tests use Testcontainers for isolated database instances:

```csharp
private readonly PostgreSqlContainer _container = new PostgreSqlBuilder()
    .WithDatabase("jerp_test")
    .WithUsername("test")
    .WithPassword("test")
    .Build();
```

## Code Coverage Goals

- **Minimum:** 70% overall coverage
- **Target:** 80% overall coverage
- **Critical paths:** 90%+ coverage (payroll, tax calculations)

## CI/CD Integration

Tests run automatically on:
- Pull requests to main branch
- Commits to develop branch
- GitHub Actions workflow

View results in Actions tab of GitHub repository.

## Best Practices

1. **Arrange-Act-Assert** pattern for test structure
2. **One assertion per test** when possible
3. **Descriptive test names** that explain what is being tested
4. **Test edge cases** and error conditions
5. **Use test data builders** for complex objects
6. **Mock external dependencies** in unit tests
7. **Use real database** in integration tests

## Debugging Tests

**Run specific test:**
```bash
dotnet test --filter "FullyQualifiedName~PayrollServiceTests"
```

**Run with detailed output:**
```bash
dotnet test --logger "console;verbosity=detailed"
```

**Debug in VS Code:**
1. Set breakpoint in test
2. Open Test Explorer
3. Right-click test → Debug Test

## Test Implementation Status

⚠️ **Note:** Test project structure is created but individual test files need to be implemented.

To implement tests:
1. Create test project: `tests/JERP.Application.Tests`
2. Add required NuGet packages (xUnit, Moq, FluentAssertions)
3. Write test classes following examples above
4. Run and verify tests pass
5. Maintain tests as code evolves
