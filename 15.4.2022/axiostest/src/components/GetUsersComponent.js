import React from "react"
import axios from "axios"

export default function GetUsers(){

  const [ user, getUser ] = React.useState([]);
    
  const getFromDb = () => {
    axios.get('https://localhost:44306/api/getusers').then((response)=>{
        
        getUser(response.data);
    })
    
}
    
  let users = user.map(user => 
    <tr key={user.Id}>
        <td>{user.Id}</td>
        <td>{user.FirstName}</td>
        <td>{user.LastName}</td>
    </tr>
  );
  
  return (
  <table>
    <thead>
      <th>Firstname</th>
      <th>Lastname</th>
    </thead>
 
    <tbody>
      <button onClick={getFromDb}>Get</button>
      {users}
    </tbody>
  </table>

  );
}