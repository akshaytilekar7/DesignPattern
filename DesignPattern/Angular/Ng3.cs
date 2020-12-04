/*

FLOW : 

main.ts - calls module which is given in bootstrapModule(AppModule)

1.  AppModule contains
    -   NgModule decorator
    -   declarations[] of components
    -   imports[] for ProductsModule and many more
    -   providers[] for services
    -   bootstrap[] for Components Ex : AppComponents

1.  Components contains metadata and methods
    -   selector
    -   templateUrl
    -   styleUrls
    -   methods for add edit save


3.  Defining Routes
    const routes: Routes = [
      { path: 'products', component: ProductListComponent },
      { path: 'products/:id', component: ProductDetailComponent, canActivate: [ProductDetailGuard] },
      { path: 'add/:id', component: ProductAddComponent , canDeactivate :[ProductAddGuardComponent] }
    ];

    @NgModule({
      imports: [RouterModule.forChild(routes)],
      exports: [RouterModule]
    })
    export class ProductRoutingModule { }

4.  Service
    
@Injectable({
  providedIn : 'root'
})
export class ProductService {
  
    private productUrl = 'assets/products/products.json';
 
    constructor(private http : HttpClient) { 
    }

      getProducts(): Observable<IProduct[]> {

        return this.http.get<IProduct[]>(this.productUrl)
          .pipe(
            tap(data => console.log('All: ' + JSON.stringify(data))),
            catchError(this.handleError)
          );
      }
  }

 */