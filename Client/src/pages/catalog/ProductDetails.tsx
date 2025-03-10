import { useEffect, useState } from "react";
import { useParams } from "react-router";
import { IProduct } from "../../model/IProduct";
import { CircularProgress, Divider, Grid2, TableBody, TableCell, TableContainer, TableRow, Typography } from "@mui/material";
import requests from "../../api/requests";
import NotFound from "../../errors/NotFound";


export default function ProductDetailsPage() { 
    const{id}=useParams<{id: string}>();  
    const[product,setProduct] =useState<IProduct | null>(null);
    const [loading, setLoading]=useState(true);
    
    useEffect(()=> { 
id && requests.Catalog.details(parseInt(id))
    .then(response=> response.json()) 
    .then(data=> setProduct(data) ) 
    .catch(error => console.log(error))
    .finally(() => setLoading(false));
    
}, [id]); 

if(loading) return <CircularProgress/>
if(!product) return <NotFound/>
    return ( 
        <Grid2 container spacing={6}> 
         <Grid2 size={{xl: 9 ,lg: 4, md: 5 , sm: 6, xs: 12}}> 
            <img src={`http://localhost:5081/images/${product.imageUrl}`} style={{width: "100%"}} />
         </Grid2> 
         <Grid2 size={{xl: 9 ,lg: 4, md: 5 , sm: 6, xs: 12}} > 
            <Typography variant="h3">{product.name}</Typography> 
            <Divider sx={{mb:2}} /> 
            <Typography variant="h4" color="secondary">{ (product.price /100).toFixed(2)}</Typography> 
             <TableContainer> 
                <table> 
                    <TableBody> 
                        <TableRow> 
                            <TableCell>Name</TableCell> 
                            <TableCell>{product.name}</TableCell>
                                </TableRow>  
                                <TableRow> 
                                    <TableCell>Description</TableCell> 
                                    <TableCell>{product.description}</TableCell>
                                </TableRow>
                                <TableRow> 
                                    <TableCell>Stock</TableCell> 
                                    <TableCell>{product.stock}</TableCell>
                                </TableRow>
                    </TableBody>
                </table>
             </TableContainer>
         </Grid2>
         </Grid2>
    );
}