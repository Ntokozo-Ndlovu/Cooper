import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

import { ChallengePostsComponent } from './challenge-posts.component';
import { BehaviorSubject } from 'rxjs';
import { Post } from 'src/app/core/models';
import dummy_data from 'src/app/core/data/dummy_data';
import { PostCardComponent } from 'src/app/core/components/post-card/post-card.component';


describe('ChallengePostsComponent', () => {
  let challengePostsComponent: ChallengePostsComponent;
  let fixture: ComponentFixture<ChallengePostsComponent>;
  let challengePostsComponentNative:HTMLElement;
  let posts:Post[] = []

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ ChallengePostsComponent, PostCardComponent ],
      schemas:[CUSTOM_ELEMENTS_SCHEMA],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(ChallengePostsComponent);
    challengePostsComponent = fixture.componentInstance;
    challengePostsComponent.posts = new BehaviorSubject<Post[]>(dummy_data.data);
    challengePostsComponentNative = fixture.debugElement.nativeElement;
    fixture.detectChanges();
    
  }));

  it('should create', () => {
    expect(challengePostsComponent).toBeTruthy();
  });

  it('given list of post should render each post as app-post-card',()=>{
    let challengeComponentPostlist = challengePostsComponentNative.querySelectorAll('app-post-card');
    expect(challengeComponentPostlist.length).withContext('to equal number of post of list').toEqual(dummy_data.data.length);
  })
});
