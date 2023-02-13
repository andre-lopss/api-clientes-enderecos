import { HttpProxy } from "vite";
import http from "../htttp-common";

class VendedorDataService{
    listar(){
        return http.get('/vendedor/listar')
    }
}