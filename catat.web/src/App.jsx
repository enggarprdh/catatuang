import * as React from "react";
import Container from "@mui/material/Container";
import Bottom from "./layouts/bottom";
import Top from "./layouts/top";
import Content from "./layouts/content";
import Home from "./pages/home";

export default function App() {
  console.log(import.meta.env.VITE_TITLE);

  return (
    <Container>
      <Top />
      <Content>
        
        <Home />
      </Content>
      <Bottom />
    </Container>
  );
}
