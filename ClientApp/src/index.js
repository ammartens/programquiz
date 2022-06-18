import React from "react";
import ReactDOM from "react-dom";
import Quiz from "./Quiz";
import { QuizProvider } from "./context/quiz";
import "./index.css";

ReactDOM.render(
  <QuizProvider>
    <Quiz />
  </QuizProvider>,
  document.getElementById("root")
);
