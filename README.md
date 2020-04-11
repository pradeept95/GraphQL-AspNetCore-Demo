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
