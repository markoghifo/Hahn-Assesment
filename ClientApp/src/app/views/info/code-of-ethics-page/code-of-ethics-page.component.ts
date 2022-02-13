import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-code-of-ethics-page',
  templateUrl: './code-of-ethics-page.component.html',
  styleUrls: ['./code-of-ethics-page.component.scss']
})
export class CodeOfEthicsPageComponent implements OnInit {

  ethics: ethic[] = [
    {
      imgSrc: '../../../../assets/images/info/code-of-ethics/originality.png',
      title: "Originality"
    },
    {
      imgSrc: '../../../../assets/images/info/code-of-ethics/queue.png',
      title: "Queuing Time"
    },
    {
      imgSrc: '../../../../assets/images/info/code-of-ethics/author.png',
      title: "Authorship: Addition or Deletion"
    },
    {
      imgSrc: '../../../../assets/images/info/code-of-ethics/author-guideline.png',
      title: "Author Guidelines"
    },
    {
      imgSrc: '../../../../assets/images/info/code-of-ethics/format.png',
      title: "Format Guide"
    },
    {
      imgSrc: '../../../../assets/images/info/code-of-ethics/books.png',
      title: "Books"
    },
    {
      imgSrc: '../../../../assets/images/info/code-of-ethics/queue.png',
      title: "Periodicals"
    },
    {
      imgSrc: '../../../../assets/images/info/code-of-ethics/author-guideline.png',
      title: "Disclosure"
    },
    {
      imgSrc: '../../../../assets/images/info/code-of-ethics/books.png',
      title: "Revised Submissions"
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}

interface ethic {
  imgSrc: string
  title: string
  // id: string
}
