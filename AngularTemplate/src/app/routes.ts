import { HomeComponent } from "./home/home.component";
import { Routes } from "@angular/router";

export const appRoutes: Routes = [
  { path: "", component: HomeComponent },

  // Activated routes examples
  // {
  //     path: '',
  //     runGuardsAndResolvers: 'always',
  //     canActivate: [AuthGuard],
  //     children: [
  //         {path: 'members', component: MemberListComponent ,
  //         resolve: {users: MemberListResolver}},
  //         {path: 'members/:userId', component: MemberDetailComponent,
  //         resolve: {user: MemberDetailResolver}},
  //         {path: 'member/edit', component: MemberEditComponent,
  //         resolve: {user: MemberEditResolver},
  //         canDeactivate: [PreventUnsavedChanges]},
  //         {path: 'messages', component: MessagesComponent},
  //         {path: 'lists', component: ListsComponent},
  //     ]
  // },

  { path: "**", redirectTo: "", pathMatch: "full" },
];
