/*

Angular
	-	binding framework
	-	SPA using routing
	-	M V VM (V- html | M - object | VM - is an Angular)
	-	features like DI, HTTP 
	- 	difference from old - TS | ComponentBased | mobileComponent | CLI | Lazy loading

Directive 
	-	used attached behaviour to HTML DOM
	-	we can write angular syntax inside HTML
	-	[(ngModel)] | [hidden] | {{value}} and many more

types of directives - SAC - structural | attribute | component
	A. structural - change structure of DOM element - add/remove element ex : *ngFor
				  - have a * sign before the directive.  *ngIf and *ngFor. 

	B. attribute - change behaviour of DOM, its dont change structure ex : hidden, ngStyle,routerLink
	C. component - user control [directive with a template]: its has own UI


We can also create custom directive. ng g directive MyDirective using wrapper @Directive. 

ElementRef:- The ElementRef gives the directive direct access to the DOM element upon which it’s attached.When the directive gets created Angular can inject an instance of
something called ElementRef into its constructor.ElementRef itself is a wrapper for the actual DOM element which we can access via the property nativeElement

Decorators:- A decorator is a function that is invoked with a prefixed “@” symbol and is immediately followed by a class, parameter, method, or property. A decorator
			 returns the same thing which was given as an input but in an augmented form. Ex:- @Component, @Injectable etc


Package.json
	-	it has all JS reference needed for project

CLI
	-	get ready-made project template with base source code

Component and Module
	-	component : write binding code
	-	Module : groups the components

Decorator/Annotation/MetaData
	-	@Component @NgModule
	-	its define class is @ngModule or @component

Tempate
	- html view of angular
	- 2 way : inline and separate file

Databind
	1. interpolation {{ }}		- Component to view
	2. propery bind [ngModel]   - Component to V
	3. event binding ()         - V to Component
	4. 2 way binding [()]   	- V to Component and Component to V

architecture/components of angular
	1. tempate - html view
	2. component - template talks with component ie, bind view and model
	3. modules - groups of component (group components logically)
	4. bindings : () [] - defines v and components communicate
	5. directives : change dom
	6. service : common logic across project
	7. DI

SPA 
	- UI loaded only ONCE and then needed ui loaded on demand
	- ex : banner/footer/header loads only once
	- and only repective data will load on click of links
	- use Angular routing

Routing 
	- collection having URL and components
	- helps to define navigations for an application

	A. RouterModule.forRoot([
		{
		  path: 'Home',
		  component: HomeComponent
		}
	  ]);
		
	B. <a [routerLink]= 'Home'>GoToHome</a>
    C. <router-outlet></router-outlet> in app.component.html.
		- when we click on B it will load HomeComponent (get this from A) in C

routing from codebehind
	- this.route.navigate(['./Home'])

Lazy loading
	- on demand load
	- to achive : DIVIDE PROJECT INTO MODULES and implment by routing
	- use loadChildren in ROUTE COLLECTION
	- separate routing file for each module and use loadChildren 
	- forRoot and forChild to specify which is the root module and child moduele
	- ex :
		RouterModule.forRoot([
		{
		  path: 'Home',
		  loadChildren: HomeComponent
		}
	 ])

canActivate 
	-	logic before navigation happens ie, preprocessing logic
	-	class Test implements CanActivate { override canActivate method) }

Service
	- share common logic accross application

DI
	-	[providers] attribute

ngServe abd ngBuild
	- ngServe		 : builds inMemory
	- ngBuild		 : builds on harddisk [create a dist folder with index.html,bunch of js files]
	- ngBuild -prod  : compress JS files, ready for production

 */