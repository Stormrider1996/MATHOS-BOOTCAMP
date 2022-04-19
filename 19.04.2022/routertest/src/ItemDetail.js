import React, { useState, useEffect } from "react";

import { useParams } from "react-router-dom";

function ItemDetail() {
    const { id } = useParams();

    useEffect(() => {
        fetchItem();
    }, []);

    const [data, setItem] = useState({});

    const fetchItem = async () => {
        const fetchItem = await fetch(`https://fortnite-api.theapinetwork.com/item/get?id=${id}`)
        const item = await fetchItem.json();
        setItem(item.data);
        console.log(item.data)
    }


    return (
        <div>
            <h1>{data.item ? data.item.name : null}</h1>
            <img src={data.item ? data.item.images.background : null} alt="" />

        </div>
    );
}

export default ItemDetail;
