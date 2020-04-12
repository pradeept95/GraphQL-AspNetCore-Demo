# GraphQl-AspNetCore-Demo
GraphQL Demo

## Request List Data Query 

      query{ 
        employees {
          firstName
          lastName
          address{
            addressLine1
          }
        }
      }

## Request info by query param

    query Query ($id : Int!){ 
      employee(id : $id) {
        id
        firstName
        lastName
        emailAddresses{
          email
        }
        addresses{
          state
        }
        phones {
          phNumber
        }
      }
    }
 
 and parameter obj
 
          {
            "id" : 2
          }
          
  ## For PagedRequest
  
 ### Request Model
              {
              "query" : {
                "searchText" : "",
                "pageNumber" : 1,
                "pageSize" : 10 
              }
            }
            
  ### Query  :
         query Query($query : PagedRequestType!){
              employeePaged(query: $query){
                data{
                  firstName
                  lastName
                  emailAddresses{
                    email
                  }
                  addresses{
                    addressLine1
                  }
                }
                totalCount
              }
            }
          
  
 # For More Query Type
 
 for more quey type with param follow below link
 https://volosoft.com/blog/Building-GraphQL-APIs-with-ASP.NET-Core
