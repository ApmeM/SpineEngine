SpineEngine aims to be a lightweight 2D framework that sits on top of MonoGame. It provides a solid base for you to build a 2D game on. Some of the many features it includes are:

- Scene/Entity/Component system with Component render layer tracking and optional entity systems (an implementation that operates on a group of entities that share a specific set of components)
- efficient coroutines for breaking up large tasks across multiple frames or animation timing (Core.startCoroutine)
- extensible rendering system. Add/remove renderers and post processors as needed. Renderables are sorted by render layer first then layer depth for maximum flexibility out of the box.
- tween system. Tween any int/float/Vector/quaternion/color/rectangle field or property.
- sprites with sprite animations
- scheduler for delayed and repeating tasks
- per-scene content managers. Load your scene-specific content then forget about it. We will unload it for you when you change scenes.
- customizable Scene transition system with several built in transitions


Systems
==========

- [Core](SpineEngine/Core.md)
- [Rendering](SpineEngine/Graphics/README.md)
- [Scene Transitions](SpineEngine/Graphics/Transitions/README.md)


Credits
==========

- [**Nez**](https://github.com/prime31/Nez) - ![GitHub stars](https://img.shields.io/github/stars/prime31/Nez.svg) - 2D game engine.
