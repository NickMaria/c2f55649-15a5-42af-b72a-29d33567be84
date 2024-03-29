# Coding Test

Working web test harness url: https://aes-code-test-web.azurewebsites.net/

## Objective

#### Translate a problem into a working solution
- task requirements were clear
- wide variety of test cases were provided in task brief  
- working software was produced

#### Demonstrate clear understanding of C# .NET
- application has been built with .Net 6.0 (should have .Net 8.0)
- web test harness was built for quick user acceptance testing  

#### Communicate solution using clean code that is easy to read/understand
- SOLID principles have been adhered to
  - Single Responsibility Principle
  - Open-Closed Principle
  - Liskov Substitution Principle
  - Interface Segregation Principle
  - Dependency Inversion Principle

#### Demonstrate ability to unit test code
- Service defined for unit testing 
- Logic was simple enough to NOT warrant abstraction into a separate module 
- Almost 100% code coverage achieved of business logic
- Code is protected with breaking unit tests  

#### Provide clear instructions on how to verify solution
- Application source code pulled down from Github
- After setting the start up project to "PatternTester", run local development 
- Project has READ_ME.txt file with local run instructions 

## Additional requirements

#### Continuous integration of solution using Github actions 
- Build on MAIN branch commit/merge
- Unit Tests are run (no fails checks as yet)
- Deployment to Azure App Service
- URL: https://aes-code-test-web.azurewebsites.net/

#### Solution containerisation using Docker
- The Web test harness project with the solution has a Docker File
- Application is able to run in a Docker container
- Deployment with a DOcker container has NOT been configured

#### Code linting
- Code linting tool added to solution 
- StyleCop.Analyzers with .editorconfig file for project-level configuration
- https://github.com/DotNetAnalyzers/StyleCopAnalyzers

#### Code coverage reporting
- Preference is .Net Code Coverage Badge
- https://github.com/marketplace/actions/net-code-coverage-badge
- in progress

