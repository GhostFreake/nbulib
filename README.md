NBU Library's E-Services
======

This projects implements a system for providing web-based services to customers of the New Bulgarian University's library. This includes students, professors, staff and other people needing the resources of the library.

It is also an experiment with a highly modular architecture, aiming to provide almost SDK-like tools for rapid development of different services(modules). These modules should be highly independent, thus every module is defining its own business rules, entity model that is coordinated with a core component called EntityDefinitionService, and UI.

The UI is also experiment of sort. It is a SPA (Single Page Application) based mainly on KnockoutJS (http://knockoutjs.com/) and Bootstrap (http://twitter.github.com/bootstrap/).

For the communication between the Frontend and the Backend the application relies on ASP.NET MVC4 WebAPI.
