> Ported from https://code.google.com/archive/p/cs2project/

# cs2project

CS2 is an academic source code search engine written in Nemerle.

CS2 stands for C# Code Search. It's an academic project developed for the course of Information Retrieval at Università di Modena e Reggio Emilia, Italy.

It's written in Nemerle for the .NET framework and built on top of several open source projects:

- [Lucene.Net](https://lucenenet.apache.org/) search engine
- [CastleProject](http://www.castleproject.org/) IoC container
- Nemerle's parser for parsing C# code
- [PowerCollections](https://github.com/timdetering/Wintellect.PowerCollections) for collections not implemeneted in the .NET framework
- [ASP.NET AJAX Control Toolkit](https://docs.microsoft.com/en-us/aspnet/ajax/) for user interface enhancements

It is capable of indexing source code files (at the moment only C# code can be parsed) and searching among them with various parameters, like class, property and method names, as well as full-text queries.

The main user interface for interacting with the search engine is an ASP.NET website built for version 4.0 of the .NET framework.

Via the homepage it's possible to query the index as well as forward requests for indexing files and directories, as shown in the screenshot below.

![This used to be an image but it's gone now](http://wiki.cs2project.googlecode.com/git/cs2.gif)

The results of the indexing can even be browsed and searched against with an application like [Luke](http://www.getopt.org/luke/).
