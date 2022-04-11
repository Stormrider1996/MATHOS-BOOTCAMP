function listTest ()
{
    var list = 
    [
        { date: '04/04/1944', reading: 3, id: 20055 },
        { date: '05/05/1955', reading: 5, id: 20053 },
        { date: '06/06/1966', reading: 6, id: 45652 }
    ];
    
    let index = document.getElementById("number").value
    
    // let result = list.map(a => a.date);
    // alert(result[index]);
    
    alert(Object.values(list[index]))


}


