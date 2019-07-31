# ServiceBus.Env Plugin - Environment specific bus filtering

This is a plugin for Microsoft.Azure.ServiceBus client.

Leverage the same bus infrastructure for multiple environments.
The same bus can be used for both dev, test, and production using filters
to allow clients/handlers to only send/retrieve messages for the matching configured environment.

## Getting Started

1. Run the app by entering the following command in the command shell:

   ```console
    dotnet run
   ```

   ```cs
    var sender = new MessageSender(connectionString, queueName);
    sender.RegisterEnvPlugin();
   ```

### Prerequisites

Install the following:

- [.NET Core](https://dotnet.microsoft.com/download).

### Installing



## Running the tests

xUnit testing

```bash
dotnet test
```


### Break down into end to end tests

Testing templates being used

```
dotnet test
```

### And coding style tests

Editor.config

```
Editor.config
```

## Deployment

```
dotnet publish
```

## Built With


## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Scott Mackenzie** - *Initial work* - [Smacktech](https://github.com/smacken)

See also the list of [contributors](https://github.com/smacken/templated/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* mmm

