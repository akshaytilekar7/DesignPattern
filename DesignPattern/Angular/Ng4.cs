/*

angular project Structure:-

e2e          :  end to end where we write our test classes. 
             :  contains automation test cases simulates as a real user

node_modules :  Contains 3rd party libraries, external modules

src          :  source code of our application i.e moduels and components

assets       :  contains static files like images

environments :  config settings for differnt environments i.e for production

main.ts      :  bootstrap the main module i.e AppModule class

pollyfills   :  It keeps features used for running angular js applicaton.
                Angular use javascript also so this file provides required
                javscript things which are not provided
                by some browsers
style        :  here we can add global styles to our application
test.ts      :  we set testing environment here
karma        :  it is a config file for karma which is a testrunner for javascript code
package.json :  it contains version, dependencies, libraries required to develop and run the application
tsconfig.j   :  contains settings for typescript compiler. 
                compiler looks for the settings and transpile typescript code into javascript
tslint       : 

webpack      :  used by angular cli. 
                it is a build automation tool. 
                it bundles the styles and other files and minifies them in bundles.
                there are bundles like polyfills,
                main.js,styles.js and pass them in index.html file.
                whenever there is a change in file, webpack automatically 
                compiles it and refreshes the browser

Angular Lifecycle hooks:-
    A lifecycle hook that is called when any data-bound property of a directive changes.
        <my-component [name]="somePropInParent"></my-component>
    This make 'name' a data-bound property.

1. ngOnChanges  :   Responds when angular sets/reset an input property.
                :   Method receives object of current and previous property values.

2. ngOnInIt     :   called after ngOnChanges.
                    When angular initilaised the component, 
                    it calls some lifecycle events i.e ngOnInIt

3. ngOnDestroy  :   Cleanup just before angular destroys the directive/component.
                    Unsubscribe observables and detach event handlers to avoid memory leaks.

In order to create a reactive forms, a parent FormGroup is must. This FormGroup can further contain formControls, child formGroups or formArray
FormArray can further contain array of formControls or a formGroup itself.

FormGroup   :
    A FormGroup aggregates the values of each child FormControl into one object, with each control name as the key. It calculates its status by reducing the status
    values of its children. For example, if one of the controls in a group is invalid, the entire group becomes invalid.
    When instantiating a FormGroup, pass in a collection of child controls as the first argument. The key for each child registers the name for the control.

 */