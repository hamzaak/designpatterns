# Proxy Pattern
## Definition
In computer programming, the proxy pattern is a software design pattern. A proxy, in its most general form, is a class functioning as an interface to something else. The proxy could interface to anything: a network connection, a large object in memory, a file, or some other resource that is expensive or impossible to duplicate. In short, a proxy is a wrapper or agent object that is being called by the client to access the real serving object behind the scenes. Use of the proxy can simply be forwarding to the real object, or can provide additional logic. In the proxy, extra functionality can be provided, for example caching when operations on the real object are resource intensive, or checking preconditions before operations on the real object are invoked. For the client, usage of a proxy object is similar to using the real object, because both implement the same interface.

## Problem
* The access to an object should be controlled.
* Additional functionality should be provided when accessing an object.
When accessing sensitive objects, for example, it should be possible to check that clients have the needed access rights.

## Solution
Define a separate Proxy object that
* can be used as substitute for another object (Subject) and
* implements additional functionality to control the access to this subject.
This enables to work through a Proxy object to perform additional functionality when accessing a subject. For example, to check the access rights of clients accessing a sensitive object.
To act as substitute for a subject, a proxy must implement the Subject interface. Clients can't tell whether they work with a subject or its proxy.

## Tutorial
1. **ICar** - Subject Interface.
2. **Car** - RealSubject Class.
3. **ProxyCar** - Proxy Class.

## References
1. [Wikipedia - Proxy pattern](https://en.wikipedia.org/wiki/Proxy_pattern)
