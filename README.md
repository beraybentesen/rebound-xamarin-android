Rebound
=====

Rebound Xamarin Binding

Rebound is a java library that models spring dynamics. Rebound spring models can be used to create animations that feel natural by introducing real world physics to your application.

Rebound is not a general purpose physics library; however, spring dynamics can be used to drive a wide variety of animations. The simplicity of Rebound makes it easy to integrate and use as a building block for creating more complex components like pagers, toggles, and scrollers.

Android resource: http://facebook.github.io/rebound/

Version : 0.3.8

Download : Available on Nuget Gallery ( https://www.nuget.org/packages/Rebound.Xamarin/ )

How do I use Rebound?
-------------------

Simple use cases :

```cs

public class MainActivity : Activity
	{
    // Define in Activity
		public Spring spring;
    ...

      // Create a system to run the physics loop for a set of springs.
			SpringSystem springSystem = SpringSystem.Create();

			// Add a spring to the system.
		    spring = springSystem.CreateSpring();

			// Defining spring listener 
			var springListener = new SpringListener(imageView, spring);

			// Setting spring listener
			spring.AddListener(springListener);

			// Set the spring in motion; moving from 0 to 1
			spring.SetEndValue(1);
```

Override OnTouchEvent
```cs
public override bool OnTouchEvent(MotionEvent e)
		{
			switch (e.Action) {
				case MotionEventActions.Down:
					spring.SetEndValue(1f);
					return true;
				case MotionEventActions.Up:
               		 spring.SetEndValue(0f);
					 return true;
		}
        return false;

		}
```

SimpleSpringListener 
```cs
public class SpringListener : SimpleSpringListener
	{
		public ImageView imageView;
		public Spring spring;

		public SpringListener(ImageView imageView,Spring spring)
		{
			this.imageView = imageView;
			this.spring = spring;
		}

		public override void OnSpringUpdate(Spring p0)
		{
			base.OnSpringUpdate(p0);

			float value = (float)spring.CurrentValue;
			float scale = 1f - (value * 0.5f);
			imageView.ScaleX = scale;
			imageView.ScaleY = scale;
		}
	} 
```

![alt tag](http://g.recordit.co/V7cjlERAu2.gif)

Author
------
Beray Bentesen -  @BerayBentesen on Twitter




