# UC#10
### Application description
Simple .Net Console Application that allows user to validate string via defined regular expression.
The minimum string length defined by regular expression as it should have at least one uppercase letter, one lowercase letter, one digit, and one special character.
Maximum length is defined by user.

### Regular expression
Application uses the following regular expression:
```^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~])[\S]{minLength,msxLength}$```

It consists of few parts:

```(?=.*[A-Z])``` -> Checks whether string contains at least one Upper character.

```(?=.*[a-z])``` -> Checks whether string contains at least one Lower character.

```(?=.*\d)``` -> Checks whether string contains at least one digit.

```(?=.*[!""#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~])``` -> Checks whether string contains at least one symbol from the defined list.
```[\S]{minLength,maxLength}``` -> Checks that string is anything other than a space, tab or newline and it in valid range.


### Application setup
1. Install .NET 6 SDK
1. Clone the app repository with your favorite GIT client
1. Open the solution
1. Run the app
1. Follow the instructions provided by the app
