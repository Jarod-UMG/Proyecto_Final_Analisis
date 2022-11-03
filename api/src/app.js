import  express  from "express";
import morgan from "morgan";
//routes

import languageRoutes from "./routes/language.routes.js";

const app=express();

// settings
app.set ("port", 4000);

// middlewares
app.use(morgan("dev"));
app.use(express.json());

//routes
app.use("/languages",languageRoutes)

export default app;