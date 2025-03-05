import { createBrowserRouter, Navigate } from "react-router";
import HomePage from "../pages/HomePage";
import App from "../components/App";
import AboutPage from "../pages/AboutPage";
import ContactPage from "../pages/ContactPage";
import CatalogPage from "../pages/catalog/CatalogPage";
import ProductDetailsPage from "../pages/catalog/ProductDetails";
import ServerError from "../errors/ServerError";


export const router=createBrowserRouter([ 
    { 
        path: "/", 
        element: <App/>, 
        children: [ 
            { path:"", element:<HomePage/>},
            { path:"about", element:<AboutPage/>},
            { path:"contact", element:<ContactPage/>}, 
            { path:"catalog", element:<CatalogPage/>},  
            { path:"server-error", element:<ServerError/>},  
            { path:"catalog/:id", element:<ProductDetailsPage/>},   
            { path : "*", element: <Navigate to="/not-found" />}

 
        ]
    }
])